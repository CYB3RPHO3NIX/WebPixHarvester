using System.ComponentModel;
using System.Net;
using System.Security.Policy;
using System.Windows.Forms;
using WebPixHarvester.Data.Models;
using WebPixHarvester.LogicLayer;
using WebPixHarvester.LogicLayer.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebPixHarvester.UserInterface
{
    public partial class MainWindow : Form
    {
        private Form _SubWindow = null;
        private LinksLoader _LinksLoader = null;
        private List<ImageDTO> _ImageList = null;

        private BackgroundWorker _worker;

        private readonly ILinkGrabber _LinkGrabber;

        public MainWindow(ILinkGrabber grabber)
        {
            InitializeComponent();
            _ImageList = new List<ImageDTO>();
            _LinkGrabber = grabber;


            _worker = new BackgroundWorker();
            _worker.WorkerSupportsCancellation = true;
            _worker.DoWork += FetchImageWorker;
            _worker.RunWorkerCompleted += FetchImageWorkerCompleted;
        }

        private void FetchImageWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                SetStatusLabel("Operation cancelled");
                SetToolStripProgressBarValue(0);
            }
            else if (e.Error != null)
            {
                SetStatusLabel($"Error: {e.Error.Message}");
            }
            else
            {
                SetStatusLabel("Operation completed successfully");
                SetToolStripProgressBarValue(0);
            }

            // Reset the button text
            button1.Text = "Start Searching";
        }

        private void FetchImageWorker(object? sender, DoWorkEventArgs e)
        {
            StartSearch(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_LinksLoader == null)
            {
                _SubWindow = new Form();
                _SubWindow.Text = "Links Loader";
                _SubWindow.Size = new Size(800, 500);
                _SubWindow.StartPosition = FormStartPosition.CenterScreen;
                _LinksLoader = new LinksLoader();
                _SubWindow.Controls.Add(_LinksLoader);
                _LinksLoader.Dock = DockStyle.Fill;
                _SubWindow.FormClosing += LinksLoaderForm_FormClosing;
            }
            _SubWindow.ShowDialog();
        }

        private void LinksLoaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            _SubWindow.Hide();     // Hide the form
        }

        //Start Searching trigger.
        private void button1_Click(object sender, EventArgs e)
        {
            if (_worker.IsBusy)
            {
                // If the background worker is busy, cancel the task
                _worker.CancelAsync();
            }
            else
            {
                // Start the background worker
                button1.Text = "Stop Searching";
                _worker.RunWorkerAsync();
            }
        }

        private void StartSearch(DoWorkEventArgs e)
        {
            List<string> urls = new List<string>();
            if (_LinksLoader != null)
            {
                SetStatusLabel("Grabbing Image links");
                SetToolStripProgressBarValue(0);
                urls = _LinksLoader.GetAllUrls();//fetching all selected URLs
                //totalURLs.Text = $"Total URLs: {urls?.Count}";

                List<string> temp = new List<string>();

                for (int i = 0; i < urls.Count; i++)
                {
                    if (_worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    temp.AddRange(_LinkGrabber.GrabAllImageLinksFrom(urls[i], GetOptions()));
                    SetToolStripProgressBarValue(GetPercentage(i, urls.Count));
                }
                for (int i = 0; i < temp.Count; i++)
                {
                    if (_ImageList.Find(e => e.ImageUrl == temp[i]) == null)
                    {
                        _ImageList.Add(new ImageDTO() { ImageUrl = temp[i] });
                    }
                }
                //totalImages.Text = $"Total Images: {_ImageList?.Count}";
                PopulateFlowLayoutPanel(e);
            }
        }
        private int GetPercentage(int current, int max)
        {
            if (max <= 0)
            {
                throw new ArgumentException("Max value must be greater than zero.", nameof(max));
            }
            double percentage = (double)current / max * 100;
            return (int)Math.Round(percentage);
        }
        private GrabberOptions GetOptions()
        {
            return new GrabberOptions()
            {
                ClassName = textBox2.Text,
                TagName = textBox1.Text,
                TargetAttribute = textBox3.Text
            };
        }

        public List<Image> GetThumbnails(List<ImageDTO> imageUrls, int thumbnailSize, DoWorkEventArgs e)
        {
            List<Image> thumbnails = new List<Image>();
            SetToolStripProgressBarValue(0);
            // Using Parallel.ForEach for multithreading
            Parallel.ForEach(imageUrls, (imageUrl, state) =>
            {
                if (_worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                Image thumbnail = GetThumbnail(imageUrl, thumbnailSize);
                thumbnails.Add(thumbnail);

                // Update progress bar
                int progress = (int)(((double)thumbnails.Count / imageUrls.Count) * 100);
                SetToolStripProgressBarValue(progress);

                // Check for cancellation (if needed)
                if (state.ShouldExitCurrentIteration)
                {
                    state.Stop();
                    return;
                }
            });

            // Reset progress bar after completion
            SetToolStripProgressBarValue(100);

            return thumbnails;
        }
        private void SetStatusLabel(string status)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    toolStripStatusLabel1.Text = status;
                });
            }
            else
            {
                toolStripStatusLabel1.Text = status;
            }
        }
        private void SetToolStripProgressBarValue(int value)
        {
            if (toolStripProgressBar1.GetCurrentParent().InvokeRequired)
            {
                toolStripProgressBar1.GetCurrentParent().Invoke((MethodInvoker)delegate
                {
                    toolStripProgressBar1.Value = value;
                });
            }
            else
            {
                toolStripProgressBar1.Value = value;
            }
        }

        private Image GetThumbnail(ImageDTO imageUrl, int thumbnailSize)
        {
            using (WebClient wc = new WebClient())
            {
                byte[] data = wc.DownloadData(imageUrl.ImageUrl);
                using (MemoryStream ms = new MemoryStream(data))
                {
                    Image fullSizeImage = Image.FromStream(ms);
                    return fullSizeImage.GetThumbnailImage(thumbnailSize, thumbnailSize, null, IntPtr.Zero);
                }
            }
        }

        private void PopulateFlowLayoutPanel(DoWorkEventArgs e, int thumbSize = 310)
        {
            ClearFlowLayoutPanelControls();
            // Assuming you have a list of image URLs in imageURLsList
            SetStatusLabel("Generating Thumbnails");
            SetToolStripProgressBarValue(0);
            var thumbImages = GetThumbnails(_ImageList, thumbSize, e);
            for (int i = 0; i < thumbImages.Count; i++)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = thumbImages[i],
                    SizeMode = PictureBoxSizeMode.Zoom, // Adjust this based on your preference
                    Width = thumbSize,
                    Height = thumbSize
                };
                AddPictureBoxToFlowLayoutPanel(pictureBox);
                SetToolStripProgressBarValue(GetPercentage(i, thumbImages.Count));
            }
        }
        private void AddPictureBoxToFlowLayoutPanel(PictureBox pictureBox)
        {
            pictureBox.Click += ImageSelectionClick;
            if (flowLayoutPanel.InvokeRequired)
            {
                flowLayoutPanel.Invoke((MethodInvoker)delegate
                {
                    flowLayoutPanel.Controls.Add(pictureBox);
                });
            }
            else
            {
                flowLayoutPanel.Controls.Add(pictureBox);
            }
        }

        private void ImageSelectionClick(object? sender, EventArgs e)
        {
            TogglePictureBoxSelection((PictureBox)sender);
        }
        private void TogglePictureBoxSelection(PictureBox pictureBox)
        {
            // Check if the PictureBox is selected
            bool isSelected = pictureBox.Tag != null && (bool)pictureBox.Tag;

            // Toggle the selection state
            isSelected = !isSelected;

            // Update the PictureBox and perform any other actions based on selection state
            UpdatePictureBoxSelection(pictureBox, isSelected);
        }

        private void UpdatePictureBoxSelection(PictureBox pictureBox, bool isSelected)
        {
            // Set the original and selected border colors
            Color originalBorderColor = Color.Transparent; // Change to the original border color
            Color selectedBorderColor = Color.Cyan; // Change to the selected border color

            // Set the border width
            int borderWidth = 20; // Adjust the thickness as needed

            // Update the PictureBox appearance based on the selection state
            if (isSelected)
            {
                // Selected state with thick border
                pictureBox.BorderStyle = BorderStyle.Fixed3D;
                pictureBox.BackColor = selectedBorderColor;
                // Perform additional actions for selected state if needed
            }
            else
            {
                // Deselected state with no border
                pictureBox.BorderStyle = BorderStyle.None;
                pictureBox.BackColor = originalBorderColor;
                // Perform additional actions for deselected state if needed
            }

            // Store the selection state in the Tag property
            pictureBox.Tag = isSelected;
        }


        private void ClearFlowLayoutPanelControls()
        {
            if (flowLayoutPanel.InvokeRequired)
            {
                flowLayoutPanel.Invoke((MethodInvoker)delegate
                {
                    flowLayoutPanel.Controls.Clear();
                });
            }
            else
            {
                flowLayoutPanel.Controls.Clear();
            }
        }

    }
}