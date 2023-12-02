namespace WebPixHarvester.UserInterface
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            totalURLs = new ToolStripStatusLabel();
            totalImages = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            upperPanel = new Panel();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lowerPanel = new Panel();
            flowLayoutPanel = new FlowLayoutPanel();
            statusStrip1.SuspendLayout();
            upperPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            lowerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { totalURLs, totalImages, toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 439);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1126, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // totalURLs
            // 
            totalURLs.Name = "totalURLs";
            totalURLs.Size = new Size(73, 17);
            totalURLs.Text = "Total URLs: 0";
            // 
            // totalImages
            // 
            totalImages.Name = "totalImages";
            totalImages.Size = new Size(85, 17);
            totalImages.Text = "Total Images: 0";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Alignment = ToolStripItemAlignment.Right;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.RightToLeft = RightToLeft.No;
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // upperPanel
            // 
            upperPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            upperPanel.Controls.Add(groupBox1);
            upperPanel.Dock = DockStyle.Top;
            upperPanel.Location = new Point(0, 0);
            upperPanel.Name = "upperPanel";
            upperPanel.Padding = new Padding(8);
            upperPanel.Size = new Size(1126, 68);
            upperPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1110, 52);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controls";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(textBox3);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1104, 30);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Load URLs";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(84, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 29);
            label1.TabIndex = 0;
            label1.Text = "Tag Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "a";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(256, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 29);
            label2.TabIndex = 3;
            label2.Text = "Class Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(331, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "rel-link";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(436, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 29);
            label4.TabIndex = 11;
            label4.Text = "Attribute";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(494, 2);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(101, 23);
            textBox3.TabIndex = 12;
            textBox3.Text = "href";
            // 
            // button1
            // 
            button1.Location = new Point(600, 3);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 5;
            button1.Text = "Start Searching";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(706, 3);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 6;
            button2.Text = "Select All";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(796, 3);
            button3.Name = "button3";
            button3.Size = new Size(118, 23);
            button3.TabIndex = 7;
            button3.Text = "Download Selected";
            button3.UseVisualStyleBackColor = true;
            // 
            // lowerPanel
            // 
            lowerPanel.Controls.Add(flowLayoutPanel);
            lowerPanel.Dock = DockStyle.Fill;
            lowerPanel.Location = new Point(0, 68);
            lowerPanel.Name = "lowerPanel";
            lowerPanel.Size = new Size(1126, 371);
            lowerPanel.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(1126, 371);
            flowLayoutPanel.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1126, 461);
            Controls.Add(lowerPanel);
            Controls.Add(upperPanel);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(1000, 498);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WebPix Harvester";
            WindowState = FormWindowState.Maximized;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            upperPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            lowerPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Panel upperPanel;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel totalURLs;
        private ToolStripStatusLabel totalImages;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel lowerPanel;
        private FlowLayoutPanel flowLayoutPanel;
        private Label label4;
        private TextBox textBox3;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}