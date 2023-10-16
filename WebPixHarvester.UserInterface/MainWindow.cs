using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebPixHarvester.UserInterface
{
    public partial class MainWindow : Form
    {
        private Form _LinksLoader = null;
        private List<string> _ImageList = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_LinksLoader == null)
            {
                _LinksLoader = new Form();
                _LinksLoader.Text = "Links Loader";
                _LinksLoader.Size = new Size(800, 500);
                _LinksLoader.StartPosition = FormStartPosition.CenterScreen;
                _LinksLoader.FormClosing += Override_FormClosing;
                LinksLoader loaderScreen = new LinksLoader();
                _LinksLoader.Controls.Add(loaderScreen);
                loaderScreen.Dock = DockStyle.Fill;
            }
            _LinksLoader.ShowDialog();
        }

        private void Override_FormClosing(object? sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _LinksLoader.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> paths = new List<string>()
            {
                "C:\\Users\\CyberPhoenix\\Desktop\\Images\\IMG (1).png",
                "C:\\Users\\CyberPhoenix\\Desktop\\Images\\IMG (2).png",
                "C:\\Users\\CyberPhoenix\\Desktop\\Images\\IMG (3).png",
                "C:\\Users\\CyberPhoenix\\Desktop\\Images\\IMG (4).png"
            };
            _ImageList = paths;
            PopulateFlowLayoutPanel();
        }
        private Image GetThumbnail(string imageUrl, int thumbnailSize)
        {
            using (WebClient wc = new WebClient())
            {
                byte[] data = wc.DownloadData(imageUrl);
                using (MemoryStream ms = new MemoryStream(data))
                {
                    Image fullSizeImage = Image.FromStream(ms);
                    return fullSizeImage.GetThumbnailImage(thumbnailSize, thumbnailSize, null, IntPtr.Zero);
                }
            }
        }
        private void PopulateFlowLayoutPanel(int thumbSize = 200)
        {
            flowLayoutPanel.Controls.Clear();
            // Assuming you have a list of image URLs in imageURLsList
            foreach (string imageUrl in _ImageList)
            {

                Image thumbnail = GetThumbnail(imageUrl, thumbSize);
                PictureBox pictureBox = new PictureBox
                {
                    Image = thumbnail,
                    SizeMode = PictureBoxSizeMode.Zoom, // Adjust this based on your preference
                    Width = thumbSize,
                    Height = thumbSize
                };
                flowLayoutPanel.Controls.Add(pictureBox);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PopulateFlowLayoutPanel(trackBar1.Value);
        }
    }
}