using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
	class Image
	{
		public static void Draw(Panel panel, List<int> points) {
			int imgSize = points.Count;
			Graphics g = panel.CreateGraphics();
			g.Clear(SystemColors.Control);
			Rectangle r = new Rectangle();
			int width = (int)Math.Floor(Math.Sqrt(imgSize));
			int height = width;
			r.Width = r.Height = (int)Math.Floor((float)(panel.Width / Math.Sqrt(width * height)));
			int cols = (int)Math.Floor((float)(panel.Width / r.Width));
			SolidBrush b = new SolidBrush(Color.Red);
			int col = 0, row = 0;
			for (int i = 0; i < points.Count; i++)
			{
				b.Color = Color.FromArgb(points[i], points[i], points[i]);
				r.X = r.Width * col;
				r.Y = r.Height * row;
				g.FillRectangle(b, r);
				col++;
				if (col == cols)
				{
					col = 0;
					row++;
				}
			}
		}

        public static void Draw1D(Panel panel, List<int> pixels)
        {
            int imageSize = pixels.Count;
            Graphics g = panel.CreateGraphics();
            g.Clear(SystemColors.Control);
            Rectangle r = new Rectangle();
            r.Y = 0;
            r.Height = panel.Height;
            r.Width = (int)Math.Floor((float)(panel.Width / imageSize));
            SolidBrush b = new SolidBrush(Color.Red);
            for (int i = 0; i < pixels.Count; i++)
            {
                b.Color = Color.FromArgb(pixels[i], pixels[i], pixels[i]);
                r.X = r.Width * i;
                g.FillRectangle(b, r);
            }
        }
    }
}
