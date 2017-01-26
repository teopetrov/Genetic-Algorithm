using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    class ExternalScreen
    {
        private Screen currentScreen;
        public ExternalScreen(int number) {
            this.currentScreen = Screen.AllScreens[number];
        }

        public void sendImage() {
            
        }
    }
}
