using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public abstract class PixelGeneratorBase : IPixelGenerator
    {
        public int pixelsCount;
        public PixelGeneratorBase(int pixelsCount)
        {
            this.pixelsCount = pixelsCount;
        }
        public abstract List<int> generatePixels(List<Gene> genes);
    }
}
