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
            this.Width = 1200;
            this.Height = 620;
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

        }

        private void pbFrame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 0, 0);
        }
    }
}
