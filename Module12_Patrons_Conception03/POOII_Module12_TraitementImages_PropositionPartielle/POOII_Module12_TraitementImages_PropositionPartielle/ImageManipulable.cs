using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Threading;

namespace POOII_Module11_Paint
{
    // Référence https://docs.microsoft.com/en-us/dotnet/api/system.drawing.bitmap.lockbits?view=dotnet-plat-ext-3.1
    public class ImageManipulable
    {
        private Bitmap m_bitmap;
        private byte[] m_valeurRVB;
        private BitmapData m_bmpData;

        public byte[] Raw
        {
            get
            {
                this.Lock();
                return this.m_valeurRVB;
            }
        }

        public int Width => this.m_bitmap.Width;
        public int Height => this.m_bitmap.Height;

        public ImageManipulable(string p_filename)
        {
            // Create a new bitmap.
            this.m_bitmap = new Bitmap(p_filename);
        }

        private void Lock()
        {
            if (!this.Locked)
            {
                // Lock the bitmap's bits.  
                Rectangle rect = new Rectangle(0, 0, this.m_bitmap.Width, this.m_bitmap.Height);
                this.m_bmpData =
                    this.m_bitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    PixelFormat.Format24bppRgb);
                //this.m_bitmap.PixelFormat);

                // Declare an array to hold the bytes of the bitmap.
                int bytes = Math.Abs(this.m_bmpData.Stride) * this.m_bitmap.Height;
                this.m_valeurRVB = new byte[bytes];

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(this.m_bmpData.Scan0, this.m_valeurRVB, 0, bytes);
            }
        }

        public bool Locked => this.m_bmpData != null;

        private void Unlock()
        {
            if (this.Locked)
            {
                int bytes = Math.Abs(this.m_bmpData.Stride) * this.m_bitmap.Height;

                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(this.m_valeurRVB, 0, this.m_bmpData.Scan0, bytes);

                // Unlock the bits.
                this.m_bitmap.UnlockBits(this.m_bmpData);
                this.m_bmpData = null;
            }
        }

        public Color this[int x, int y]
        {
            get
            {
                Color res;
                if (this.Locked)
                {
                    int pixel = (y * this.m_bitmap.Width + x) * 3;
                    res = Color.FromArgb(this.m_valeurRVB[pixel], this.m_valeurRVB[pixel + 1], this.m_valeurRVB[pixel + 2]);
                }
                else
                {
                    res = this.m_bitmap.GetPixel(x, y);
                }

                return res;
            }
            set
            {
                this.Lock();
                int pixel = (y * this.m_bitmap.Width + x) * 3;
                this.m_valeurRVB[pixel] = value.R;
                this.m_valeurRVB[pixel + 1] = value.G;
                this.m_valeurRVB[pixel + 2] = value.B;

            }
        }

        public Bitmap Image
        {
            get
            {
                this.Unlock();

                return this.m_bitmap;
            }
        }
    }
}
