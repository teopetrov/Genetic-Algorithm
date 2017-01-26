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
    public partial class FullScreenImage : Form
    {
        public FullScreenImage()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            pаnеlImage.Dock = DockStyle.Fill;
        }

        public void drawImage(List<int> pixels) {
            Image.Draw1D(pаnеlImage, pixels);
        }
    }
}
