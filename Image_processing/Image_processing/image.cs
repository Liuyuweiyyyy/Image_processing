using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Image_processing
{
    public partial class image : Form
    {
        [DllImport(@"..\..\..\..\x64\Debug\SetImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void negative(int[] img, int size);
        [DllImport(@"..\..\..\..\x64\Debug\SetImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void clockwise90(int[] img, int w, int h);
        [DllImport(@"..\..\..\..\x64\Debug\SetImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void inverse90(int[] img, int w, int h);
        [DllImport(@"..\..\..\..\x64\Debug\SetImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void left_right(int[] img, int w, int h);
        [DllImport(@"..\..\..\..\x64\Debug\SetImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void up_down(int[] img, int w, int h);

        internal Bitmap pBitmap;
        internal ToolStripStatusLabel pf1;

        public image()
        {
            InitializeComponent();
        }

        private int[] dyn_bmp2array(Bitmap myBitmap, ref int ByteDepth, ref PixelFormat pixelFormat, ref ColorPalette palette)
        {
            int w = myBitmap.Width, h = myBitmap.Height;
            BitmapData byteArray = myBitmap.LockBits(
                    new Rectangle(0, 0, w, h),
                    ImageLockMode.ReadWrite,
                    myBitmap.PixelFormat);
            pixelFormat = myBitmap.PixelFormat;
            palette = myBitmap.Palette;
            ByteDepth = (int)(byteArray.Stride / w);
            int[] ImgData = new int[w * h * ByteDepth];
            int ByteOfSkip = byteArray.Stride - w * ByteDepth;

            unsafe
            {
                byte* ptr = (byte*)byteArray.Scan0;
                for (int y = 0; y < h; y++)
                {
                    for (int x = 0; x < w; x++)
                    {
                        for (int c = 0; c < ByteDepth; c++)
                        {
                            ImgData[(y * w + x) * ByteDepth + c] = *ptr;
                            ptr++;
                        }
                    }
                    ptr += ByteOfSkip;
                }
            }
            myBitmap.UnlockBits(byteArray);
            return ImgData;
        }

        private static Bitmap dyn_array2bmp(int[] ImgData, int ByteDepth, PixelFormat pixelFormat, ColorPalette palette) // 限正方形，出灰階
        {
            int w = (int)Math.Sqrt(ImgData.GetLength(0) / ByteDepth);
            int h = (int)Math.Sqrt(ImgData.GetLength(0) / ByteDepth);
            Bitmap myBitmap = new Bitmap(w, h, pixelFormat);
            BitmapData byteArray = myBitmap.LockBits(
                    new Rectangle(0, 0, w, h),
                    ImageLockMode.WriteOnly,
                    pixelFormat);

            try
            {
                myBitmap.Palette = palette;
            }
            catch
            {

            }

            int ByteOfSkip = byteArray.Stride - w * ByteDepth;
            unsafe
            {
                byte* ptr = (byte*)byteArray.Scan0;
                for (int y = 0; y < h; y++)
                {
                    for (int x = 0; x < w; x++)
                    {
                        for (int c = 0; c < ByteDepth; c++)
                        {
                            *ptr = (byte)ImgData[(y * w + x) * ByteDepth + c];
                            ptr++;
                        }
                    }
                    ptr += ByteOfSkip;
                }
            }
            myBitmap.UnlockBits(byteArray);
            return myBitmap;
        }

        private void bmp_dip(Bitmap pBitmap, PictureBox pictureBox)
        {
            this.Width = pBitmap.Width + (this.Width - this.ClientRectangle.Width);
            this.Height = pBitmap.Height + (this.Height - this.ClientRectangle.Height);
            pictureBox1.Image = pBitmap;
            pictureBox1.Width = pBitmap.Width;
            pictureBox1.Height = pBitmap.Height;
        }
        private void image_Load(object sender, EventArgs e)
        {
            bmp_dip(pBitmap, pictureBox1);
            pf1.Text = "(Width, Height) = (" + pBitmap.Width + ", " + pBitmap.Height + ")";
        }
        public void bmp_read(OpenFileDialog oFileDlg)
        {
            string fileloc = oFileDlg.FileName;
            pBitmap = new Bitmap(fileloc);
            pictureBox1.Image = Image.FromFile(fileloc);
        }

        public Bitmap rotate(Bitmap src, int flag)
        {
            int w = src.Width, h = src.Height;
            int[] pixels = new int[w * h];
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color c = src.GetPixel(x, y);
                    pixels[y * w + x] = c.R;
                }
            }

            switch (flag)
            {
                case 0: // 順時針90度
                    clockwise90(pixels, w, h);
                    break;
                case 1: // 逆時針90度
                    inverse90(pixels, w, h);
                    break;
                case 2: // 左右反轉
                    left_right(pixels, w, h);
                    break;
                case 3: // 上下反轉
                    up_down(pixels, w, h);
                    break;
            }

            Bitmap newBmp = new Bitmap(h, w);
            for (int y = 0; y < w; y++)
            {
                for (int x = 0; x < h; x++)
                {
                    int v = pixels[y * h + x];
                    newBmp.SetPixel(x, y, Color.FromArgb(v, v, v));
                }
            }
            return newBmp;
        }

        public Bitmap Negative(Bitmap src)
        {
            int w = src.Width, h = src.Height;
            int[] pixels = new int[w * h];
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color c = src.GetPixel(x, y);
                    pixels[y * w + x] = c.R;
                }
            }
            negative(pixels, pixels.Length);

            Bitmap newBmp = new Bitmap(w, h);
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    int v = pixels[y * w + x];
                    newBmp.SetPixel(x, y, Color.FromArgb(v, v, v));
                }
            }
            return newBmp;
        }
    }
}