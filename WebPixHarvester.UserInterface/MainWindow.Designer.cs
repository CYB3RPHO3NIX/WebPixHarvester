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
            toolStripProgressBar1 = new ToolStripProgressBar();
            upperPanel = new Panel();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            trackBar1 = new TrackBar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lowerPanel = new Panel();
            flowLayoutPanel = new FlowLayoutPanel();
            statusStrip1.SuspendLayout();
            upperPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            lowerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { totalURLs, totalImages, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 439);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // totalURLs
            // 
            totalURLs.Name = "totalURLs";
            totalURLs.Size = new Size(85, 17);
            totalURLs.Text = "Total URLs: 234";
            // 
            // totalImages
            // 
            totalImages.Name = "totalImages";
            totalImages.Size = new Size(97, 17);
            totalImages.Text = "Total Images: 400";
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
            upperPanel.Size = new Size(984, 68);
            upperPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(968, 52);
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
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(trackBar1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(962, 30);
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
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(437, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 29);
            label3.TabIndex = 9;
            label3.Text = "Thumbnail Size";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            trackBar1.Location = new Point(530, 3);
            trackBar1.Maximum = 500;
            trackBar1.Minimum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 23);
            trackBar1.SmallChange = 50;
            trackBar1.TabIndex = 10;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(640, 3);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 5;
            button1.Text = "Start Searching";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(746, 3);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 6;
            button2.Text = "Select All";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(836, 3);
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
            lowerPanel.Size = new Size(984, 371);
            lowerPanel.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(984, 371);
            flowLayoutPanel.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(984, 461);
            Controls.Add(lowerPanel);
            Controls.Add(upperPanel);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(1000, 500);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WebPix Harvester";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            upperPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
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
        private Label label3;
        private TrackBar trackBar1;
    }
}