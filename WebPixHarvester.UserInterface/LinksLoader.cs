﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebPixHarvester.UserInterface
{
    public partial class LinksLoader : UserControl
    {
        public LinksLoader()
        {
            InitializeComponent();
        }
        private List<string> GetLinesFromTextBox(System.Windows.Forms.TextBox textBox)
        {
            // Split the text based on line breaks and return as a List<string>
            return new List<string>(textBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None));
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Clear whats existing
            var links = GetLinesFromTextBox(textBox1);
            PopulateCheckedListBox(links);
        }
        private void PopulateCheckedListBox(List<string> links)
        {
            checkedListBox1.Items.Clear();
            if (links.Count > 0 && links[0] != "")
            {
                foreach (string item in links)
                {
                    checkedListBox1.Items.Add(item, false);
                }
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.Items.Count > 0)
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBox1.Text = Clipboard.GetText();
            }
        }
    }
}
