using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public abstract class PixelGeneratorParametric : PixelGeneratorBase
    {
        protected double normalizationStep = 0;
        protected double normalizationMultiplier = 0;
        public PixelGeneratorParametric(int imageSize) : base(imageSize)
        {
            this.normalizationStep = Math.Abs(this.calculateMinFunctionValue() - Configuration.pixelMinValue);
            this.normalizationMultiplier = 255 / Math.Abs((calculateMaxFunctionValue() - calculateMinFunctionValue()));
        }
        public override List<int> generatePixels(List<Gene> genes)
        {
            List<int> res = new List<int>();
            List<int> parameters = new List<int>();
            foreach (Gene gene in genes)
            {
                parameters.Add(gene.Value);
            }
            for (int i = 0; i < this.pixelsCount; i++)
            {
                res.Add(this.generatePixel(i, parameters));
            }
            return res;
        }
        protected int generatePixel(int x, List<int> parameters)
        {
            return Math.Abs((int)Math.Round(this.normalizationMultiplier * calculateFunctionValue(x, parameters) + this.normalizationStep));
        }
        protected abstract double calculateFunctionValue(int x, List<int> parameters = null);
        protected abstract double calculateMinFunctionValue();
        protected abstract double calculateMaxFunctionValue();

    }
}
