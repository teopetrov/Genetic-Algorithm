using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public abstract class IndividualBase : IIndividual, ICloneable
    {
        public int imageSize;
        public double fitness = 0;
        public List<Gene> genes;
        public List<int> pixels;
        
        public IndividualBase(int size, List<Gene> genes)
        {
            this.imageSize = size;
            this.genes = genes;
        }
        public double getFitness()
        {
            return this.fitness;
        }
        public void generatePixels(IPixelGenerator pixelGenerator) {
            this.pixels = pixelGenerator.generatePixels(this.genes);
        }
        public List<int> getPixels(IPixelGenerator pixelGenerator)
        {
            if (this.pixels == null)
            {
                generatePixels(pixelGenerator);
            }
            return this.pixels;
        }
        public void setFitness(double fitness)
        {
            this.fitness = fitness;
        }
        public int CompareTo(object other)
        {
            return this.getFitness().CompareTo(((IIndividual)other).getFitness());
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
