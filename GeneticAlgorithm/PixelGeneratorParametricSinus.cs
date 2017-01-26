using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    [Status(Utilities.DevelopementStatus.Draft)]
    [DDL("PixelGeneratorParametricSinus", "Sinus parametric")]
    public class PixelGeneratorParametricSinus : PixelGeneratorParametric
    {
        public PixelGeneratorParametricSinus(int imageSize) : base(imageSize)
        {
        }
        protected override double calculateFunctionValue(int x, List<int> parameters = null)
        {
            double res = x;
            for (int i = 0; i < parameters.Count; i++)
            {
                res += parameters[i] * Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / Utilities.factorial(i);
            }
            return res;
        }        
        protected override double calculateMinFunctionValue()
        {
            List<Gene> inputParameters = Parameters.getParametersAsGenes();
            List<int> parameters = new List<int>();
            for (int i = 0; i < inputParameters.Count; i++)
            {
                if (i % 2 == 0)
                {
                    parameters.Add(inputParameters[i].MinValue);
                }
                else
                {
                    parameters.Add(inputParameters[i].MaxValue);
                }
            }
            double res = this.calculateFunctionValue(0, parameters);
            for (int i = 1; i < Parameters.getImageSize(); i++)
            {
                if (this.calculateFunctionValue(i, parameters) < res)
                {
                    res = this.calculateFunctionValue(i, parameters);
                }
            }
            return res;
        }
        protected override double calculateMaxFunctionValue()
        {
            List<Gene> inputParameters = Parameters.getParametersAsGenes();
            List<int> parameters = new List<int>();
            for (int i = 0; i < inputParameters.Count; i++)
            {
                if (i % 2 == 0)
                {
                    parameters.Add(inputParameters[i].MaxValue);
                }
                else
                {
                    parameters.Add(inputParameters[i].MinValue);
                }
            }
            double res = this.calculateFunctionValue(0, parameters);
            for (int i = 1; i < Parameters.getImageSize(); i++)
            {
                if (this.calculateFunctionValue(i, parameters) > res)
                {
                    res = this.calculateFunctionValue(i, parameters);
                }
            }
            return res;
        }        
    }
}
