using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    static class AbstractFactory
    {
        public static AlgorithmBase CreateAlgorithm()
        {
            AlgorithmBase ret = null;
            try
            {
                ret = (AlgorithmBase)Activator.CreateInstance(Type.GetType("Algorithms." + Parameters.getStopCondition()));
            }
            catch { }
            return ret;
        }
        public static IEvaluator CreateEvaluator(string evaluatorClass)
        {
            switch (evaluatorClass)
            {
                case "EvaluatorLocal":
                    return new EvaluatorLocal(Parameters.getImageSize());
                default:
                    IEvaluator ret = null;
                    try
                    {
                        ret = (IEvaluator)Activator.CreateInstance(Type.GetType("GeneticAlgorithm." + evaluatorClass));
                    }
                    catch { }
                    return ret;
            }

        }
        public static IndividualBase CreateIndividual(int imageSize, string calculationMethod, List<Gene> generatedGenes = null)
        {
            switch (calculationMethod)
            {
                case "PixelGeneratorRandom":
                    List<Gene> genes;
                    if (generatedGenes == null)
                    {
                        genes = new List<Gene>();
                        for (int i = 0; i < imageSize; i++)
                        {
                            genes.Add(new Gene(0, 255));
                        }
                    }
                    else
                    {
                        genes = new List<Gene>(generatedGenes);
                    }
                    return new IndividualRandom(imageSize, genes);
                case "PixelGeneratorParametricSinus":
                    if (generatedGenes == null)
                    {
                        generatedGenes = Parameters.getParametersAsGenes();
                    }
                    return new IndividualSimpleParametric(imageSize, generatedGenes);
                default:
                    throw new Exception("Cannot create individual.");
            }
        }
        public static IPixelGenerator CreatePixelGenerator(int imageSize, string calculationMethod)
        {
            switch (calculationMethod)
            {
                case "PixelGeneratorRandom":
                    return new PixelGeneratorRandom(imageSize);
                case "PixelGeneratorParametricSinus":
                    return new PixelGeneratorParametricSinus(imageSize);
                default:
                    throw new Exception("Cannot create pixel generator.");
            }
        }
        public static IPopulationSelector CreatePopulationSelector(string selectionMethod)
        {
            IPopulationSelector ret = null;
            try
            {
                ret = (IPopulationSelector)Activator.CreateInstance(Type.GetType("SelectionMethods." + selectionMethod));
            }
            catch { }
            return ret;
        }
    }
}
