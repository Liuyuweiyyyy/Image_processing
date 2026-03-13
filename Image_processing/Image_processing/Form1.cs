using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Image_processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.toolStripStatusLabel1.Text = "";
        }

        private void OnlyClick(ToolStripMenuItem item) // 只能選選單的其中一個
        {
            foreach (ToolStripMenuItem i in item.Owner.Items)
                i.Checked = false;
            item.Checked = true;
        }

        // -------------------- 檔案 --------------------
        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Title = "Open File";
            openFileDialog1.ValidateNames = true;
            openFileDialog1.Filter =
                "Bitmap Files (*.bmp)|*.bmp|" +
                "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "PNG Files (*.png)|*.png|" +
                "GIF Files (*.gif)|*.gif|" +
                "All Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image childForm = new image();
                childForm.MdiParent = this;
                childForm.pf1 = toolStripStatusLabel1;
                childForm.bmp_read(openFileDialog1);
                childForm.Show();
            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is image childForm)
            {
                Bitmap bmp = childForm.pBitmap;

                saveFileDialog1.Title = "Save Image";
                saveFileDialog1.Filter =
                "Bitmap Files (*.bmp)|*.bmp|" +
                "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "PNG Files (*.png)|*.png|" +
                "GIF Files (*.gif)|*.gif|" +
                "All Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.FileName = "image";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(saveFileDialog1.FileName);
                }
            }
        }

        // -------------------- 檢視 --------------------
        private void 縮放ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 旋轉ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 順時針旋轉90度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is image childForm)
            {
                image newChild = new image();
                newChild.MdiParent = this;
                newChild.pf1 = toolStripStatusLabel1;
                newChild.pBitmap = childForm.rotate(childForm.pBitmap, 0);

                newChild.Show();
            }
        }

        private void 逆時針旋轉90度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is image childForm)
            {
                image newChild = new image();
                newChild.MdiParent = this;
                newChild.pf1 = toolStripStatusLabel1;
                newChild.pBitmap = childForm.rotate(childForm.pBitmap, 1);

                newChild.Show();
            }
        }

        private void 左右顛倒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is image childForm)
            {
                image newChild = new image();
                newChild.MdiParent = this;
                newChild.pf1 = toolStripStatusLabel1;
                newChild.pBitmap = childForm.rotate(childForm.pBitmap, 2);

                newChild.Show();
            }
        }

        private void 上下顛倒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is image childForm)
            {
                image newChild = new image();
                newChild.MdiParent = this;
                newChild.pf1 = toolStripStatusLabel1;
                newChild.pBitmap = childForm.rotate(childForm.pBitmap, 3);

                newChild.Show();
            }
        }

        // -------------------- 影像 --------------------
        private void 樣式ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnlyClick((ToolStripMenuItem)sender);
        }
        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnlyClick((ToolStripMenuItem)sender);
        }

        private void 負片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is image childForm)
            {
                image newChild = new image();
                newChild.MdiParent = this;
                newChild.pf1 = toolStripStatusLabel1;
                newChild.pBitmap = childForm.Negative(childForm.pBitmap);

                newChild.Show();
            }
        }
    }
}
