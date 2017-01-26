using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    [Status(Utilities.DevelopementStatus.Active)]
    [DDL("PixelGeneratorRandom", "Random pixels")]
    public class PixelGeneratorRandom : PixelGeneratorBase
    {
        public PixelGeneratorRandom(int pixelsCount) : base(pixelsCount)
        {
        }
        public override List<int> generatePixels(List<Gene> genes)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < this.pixelsCount; i++)
            {
                res.Add(genes[i].Value);
            }
            return res;
        }
    }
}
