using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPixHarvester.UserInterface
{
    public partial class LinksLoader : UserControl
    {
        public LinksLoader()
        {
            InitializeComponent();
        }
        private List<string> GetLinesFromTextBox(TextBox textBox)
        {
            // Split the text based on line breaks and return as a List<string>
            return new List<string>(textBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None));
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Clear whats existing
            checkedListBox1.Items.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripButton2.Text == "Select All")
            {
                toolStripButton2.Text = "Deselect All";
                if (checkedListBox1.Items.Count > 0)
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }
            }
            else
            {
                toolStripButton2.Text = "Select All";
                if (checkedListBox1.Items.Count > 0)
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
        }
    }
}
