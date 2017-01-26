using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public interface IPixelGenerator
    {
        List<int> generatePixels(List<Gene> genes);
    }
}
