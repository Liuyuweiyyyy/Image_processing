namespace Image_processing
{
    partial class Form1
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
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            檔案ToolStripMenuItem = new ToolStripMenuItem();
            開啟ToolStripMenuItem = new ToolStripMenuItem();
            儲存ToolStripMenuItem = new ToolStripMenuItem();
            檢視ToolStripMenuItem = new ToolStripMenuItem();
            縮放ToolStripMenuItem = new ToolStripMenuItem();
            旋轉ToolStripMenuItem = new ToolStripMenuItem();
            順時針旋轉90度ToolStripMenuItem = new ToolStripMenuItem();
            逆時針旋轉90度ToolStripMenuItem = new ToolStripMenuItem();
            左右顛倒ToolStripMenuItem = new ToolStripMenuItem();
            上下顛倒ToolStripMenuItem = new ToolStripMenuItem();
            影像ToolStripMenuItem = new ToolStripMenuItem();
            樣式ToolStripMenuItem = new ToolStripMenuItem();
            rGBToolStripMenuItem = new ToolStripMenuItem();
            grayToolStripMenuItem = new ToolStripMenuItem();
            負片ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 檔案ToolStripMenuItem, 檢視ToolStripMenuItem, 影像ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開啟ToolStripMenuItem, 儲存ToolStripMenuItem });
            檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            檔案ToolStripMenuItem.Size = new Size(53, 24);
            檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開啟ToolStripMenuItem
            // 
            開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            開啟ToolStripMenuItem.Size = new Size(224, 26);
            開啟ToolStripMenuItem.Text = "開啟";
            開啟ToolStripMenuItem.Click += 開啟ToolStripMenuItem_Click;
            // 
            // 儲存ToolStripMenuItem
            // 
            儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            儲存ToolStripMenuItem.Size = new Size(224, 26);
            儲存ToolStripMenuItem.Text = "儲存";
            儲存ToolStripMenuItem.Click += 儲存ToolStripMenuItem_Click;
            // 
            // 檢視ToolStripMenuItem
            // 
            檢視ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 縮放ToolStripMenuItem, 旋轉ToolStripMenuItem });
            檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            檢視ToolStripMenuItem.Size = new Size(53, 24);
            檢視ToolStripMenuItem.Text = "檢視";
            // 
            // 縮放ToolStripMenuItem
            // 
            縮放ToolStripMenuItem.Name = "縮放ToolStripMenuItem";
            縮放ToolStripMenuItem.Size = new Size(224, 26);
            縮放ToolStripMenuItem.Text = "縮放";
            縮放ToolStripMenuItem.Click += 縮放ToolStripMenuItem_Click;
            // 
            // 旋轉ToolStripMenuItem
            // 
            旋轉ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 順時針旋轉90度ToolStripMenuItem, 逆時針旋轉90度ToolStripMenuItem, 左右顛倒ToolStripMenuItem, 上下顛倒ToolStripMenuItem });
            旋轉ToolStripMenuItem.Name = "旋轉ToolStripMenuItem";
            旋轉ToolStripMenuItem.Size = new Size(224, 26);
            旋轉ToolStripMenuItem.Text = "旋轉";
            旋轉ToolStripMenuItem.Click += 旋轉ToolStripMenuItem_Click;
            // 
            // 順時針旋轉90度ToolStripMenuItem
            // 
            順時針旋轉90度ToolStripMenuItem.Name = "順時針旋轉90度ToolStripMenuItem";
            順時針旋轉90度ToolStripMenuItem.Size = new Size(224, 26);
            順時針旋轉90度ToolStripMenuItem.Text = "順時針旋轉90度";
            順時針旋轉90度ToolStripMenuItem.Click += 順時針旋轉90度ToolStripMenuItem_Click;
            // 
            // 逆時針旋轉90度ToolStripMenuItem
            // 
            逆時針旋轉90度ToolStripMenuItem.Name = "逆時針旋轉90度ToolStripMenuItem";
            逆時針旋轉90度ToolStripMenuItem.Size = new Size(224, 26);
            逆時針旋轉90度ToolStripMenuItem.Text = "逆時針旋轉90度";
            逆時針旋轉90度ToolStripMenuItem.Click += 逆時針旋轉90度ToolStripMenuItem_Click;
            // 
            // 左右顛倒ToolStripMenuItem
            // 
            左右顛倒ToolStripMenuItem.Name = "左右顛倒ToolStripMenuItem";
            左右顛倒ToolStripMenuItem.Size = new Size(224, 26);
            左右顛倒ToolStripMenuItem.Text = "左右顛倒";
            左右顛倒ToolStripMenuItem.Click += 左右顛倒ToolStripMenuItem_Click;
            // 
            // 上下顛倒ToolStripMenuItem
            // 
            上下顛倒ToolStripMenuItem.Name = "上下顛倒ToolStripMenuItem";
            上下顛倒ToolStripMenuItem.Size = new Size(224, 26);
            上下顛倒ToolStripMenuItem.Text = "上下顛倒";
            上下顛倒ToolStripMenuItem.Click += 上下顛倒ToolStripMenuItem_Click;
            // 
            // 影像ToolStripMenuItem
            // 
            影像ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 樣式ToolStripMenuItem, 負片ToolStripMenuItem });
            影像ToolStripMenuItem.Name = "影像ToolStripMenuItem";
            影像ToolStripMenuItem.Size = new Size(53, 24);
            影像ToolStripMenuItem.Text = "影像";
            // 
            // 樣式ToolStripMenuItem
            // 
            樣式ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rGBToolStripMenuItem, grayToolStripMenuItem });
            樣式ToolStripMenuItem.Name = "樣式ToolStripMenuItem";
            樣式ToolStripMenuItem.Size = new Size(224, 26);
            樣式ToolStripMenuItem.Text = "樣式";
            樣式ToolStripMenuItem.Click += 樣式ToolStripMenuItem_Click;
            // 
            // rGBToolStripMenuItem
            // 
            rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            rGBToolStripMenuItem.Size = new Size(224, 26);
            rGBToolStripMenuItem.Text = "RGB";
            rGBToolStripMenuItem.Click += rGBToolStripMenuItem_Click;
            // 
            // grayToolStripMenuItem
            // 
            grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            grayToolStripMenuItem.Size = new Size(224, 26);
            grayToolStripMenuItem.Text = "Gray";
            grayToolStripMenuItem.Click += grayToolStripMenuItem_Click;
            // 
            // 負片ToolStripMenuItem
            // 
            負片ToolStripMenuItem.Name = "負片ToolStripMenuItem";
            負片ToolStripMenuItem.Size = new Size(224, 26);
            負片ToolStripMenuItem.Text = "負片";
            負片ToolStripMenuItem.Click += 負片ToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 25);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(158, 19);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem 開啟ToolStripMenuItem;
        private ToolStripMenuItem 儲存ToolStripMenuItem;
        private ToolStripMenuItem 檢視ToolStripMenuItem;
        private ToolStripMenuItem 縮放ToolStripMenuItem;
        private ToolStripMenuItem 旋轉ToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem 順時針旋轉90度ToolStripMenuItem;
        private ToolStripMenuItem 逆時針旋轉90度ToolStripMenuItem;
        private ToolStripMenuItem 左右顛倒ToolStripMenuItem;
        private ToolStripMenuItem 上下顛倒ToolStripMenuItem;
        private ToolStripMenuItem 影像ToolStripMenuItem;
        private ToolStripMenuItem 樣式ToolStripMenuItem;
        private ToolStripMenuItem rGBToolStripMenuItem;
        private ToolStripMenuItem grayToolStripMenuItem;
        private ToolStripMenuItem 負片ToolStripMenuItem;
    }
}
