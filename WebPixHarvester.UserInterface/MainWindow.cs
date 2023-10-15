using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebPixHarvester.UserInterface
{
    public partial class MainWindow : Form
    {
        private Form _LinksLoader = null;
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
            
        }
        
    }
}