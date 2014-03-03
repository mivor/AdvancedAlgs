using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedAlgs
{
    public partial class Form1 : Form
    {
        private Bitmap image;

        public Form1()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 550;
            pbFrame.Width = this.Width;
            pbFrame.Height = this.Height;

            image = new Bitmap(pbFrame.Width, pbFrame.Height);
            using (Graphics gx = Graphics.FromImage(image))
            {
                // uncomment for higher quality output
                gx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                gx.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                gx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // test
                gx.DrawEllipse(new Pen(Color.Red), 10, 10, 333, 333);
                gx.DrawRectangle(new Pen(Color.Green), 50, 50, 200, 200);
            }

            Point startPos = new Point(10, 10);
            Size startSize = new Size(450, 450);
            clearImage();
            drawRect(startPos, startSize);
        }

        private void clearImage()
        {
            using (Graphics gx = Graphics.FromImage(image))
            {
                gx.Clear(Color.White);
            }
        }

        private void drawRect(Point pos, Size size)
        {
            using (Graphics gx = Graphics.FromImage(image))
            {
                gx.FillRectangle(new SolidBrush(Color.Plum), pos.X, pos.Y, size.Width, size.Height);
            }
        }

        private void pbFrame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 0, 0);
        }
    }
}
