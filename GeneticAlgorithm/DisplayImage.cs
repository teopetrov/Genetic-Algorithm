using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class DisplayImage : Form
    {
        public DisplayImage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Image img = Image.FromFile("test.jpg");
            picImage.Image = img;
            picImage.Height = img.Height;
            picImage.Width = img.Width;
            picImage.Dock = DockStyle.Fill;
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;          
        }
    }
}
