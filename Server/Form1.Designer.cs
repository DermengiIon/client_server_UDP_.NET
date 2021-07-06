
namespace Server
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.elNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.elFrameNoLabel = new System.Windows.Forms.Label();
            this.elStartBtn = new System.Windows.Forms.Button();
            this.elPictureBox = new System.Windows.Forms.PictureBox();
            this.elPauseBtn = new System.Windows.Forms.Button();
            this.elFpsLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.videoToolStripMenuItem.Text = "Video";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.elFpsLabel);
            this.splitContainer1.Panel1.Controls.Add(this.elPauseBtn);
            this.splitContainer1.Panel1.Controls.Add(this.elNumericUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.elFrameNoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.elStartBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.elPictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 422);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 1;
            // 
            // elNumericUpDown
            // 
            this.elNumericUpDown.Location = new System.Drawing.Point(700, 22);
            this.elNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.elNumericUpDown.Name = "elNumericUpDown";
            this.elNumericUpDown.Size = new System.Drawing.Size(88, 22);
            this.elNumericUpDown.TabIndex = 2;
            this.elNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // elFrameNoLabel
            // 
            this.elFrameNoLabel.AutoSize = true;
            this.elFrameNoLabel.Location = new System.Drawing.Point(267, 24);
            this.elFrameNoLabel.Name = "elFrameNoLabel";
            this.elFrameNoLabel.Size = new System.Drawing.Size(139, 17);
            this.elFrameNoLabel.TabIndex = 1;
            this.elFrameNoLabel.Text = "Frame / Total frames";
            // 
            // elStartBtn
            // 
            this.elStartBtn.Location = new System.Drawing.Point(12, 21);
            this.elStartBtn.Name = "elStartBtn";
            this.elStartBtn.Size = new System.Drawing.Size(75, 23);
            this.elStartBtn.TabIndex = 0;
            this.elStartBtn.Text = "Start";
            this.elStartBtn.UseVisualStyleBackColor = true;
            this.elStartBtn.Click += new System.EventHandler(this.elStartBtn_Click);
            // 
            // elPictureBox
            // 
            this.elPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elPictureBox.Location = new System.Drawing.Point(0, 0);
            this.elPictureBox.Name = "elPictureBox";
            this.elPictureBox.Size = new System.Drawing.Size(800, 352);
            this.elPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elPictureBox.TabIndex = 0;
            this.elPictureBox.TabStop = false;
            // 
            // elPauseBtn
            // 
            this.elPauseBtn.Location = new System.Drawing.Point(104, 21);
            this.elPauseBtn.Name = "elPauseBtn";
            this.elPauseBtn.Size = new System.Drawing.Size(75, 23);
            this.elPauseBtn.TabIndex = 3;
            this.elPauseBtn.Text = "Pause";
            this.elPauseBtn.UseVisualStyleBackColor = true;
            this.elPauseBtn.Click += new System.EventHandler(this.elPauseBtn_Click);
            // 
            // elFpsLabel
            // 
            this.elFpsLabel.AutoSize = true;
            this.elFpsLabel.Location = new System.Drawing.Point(559, 24);
            this.elFpsLabel.Name = "elFpsLabel";
            this.elFpsLabel.Size = new System.Drawing.Size(47, 17);
            this.elFpsLabel.TabIndex = 4;
            this.elFpsLabel.Text = "Fps: 0";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox elPictureBox;
        private System.Windows.Forms.Button elStartBtn;
        private System.Windows.Forms.Label elFrameNoLabel;
        private System.Windows.Forms.NumericUpDown elNumericUpDown;
        private System.Windows.Forms.Button elPauseBtn;
        private System.Windows.Forms.Label elFpsLabel;
    }
}

