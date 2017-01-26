using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    static class Merger
    {
        private static List<Gene> mergeGenes(List<List<Gene>> input, List<double> ratio, int? genesCount = null)
        {
            if (genesCount == null)
            {
                genesCount = input[0].Count;
            }
            List<Gene> res = new List<Gene>();
            return res;
        }
        public static List<Gene> mergeGenes(List<Gene> genes1, List<Gene> genes2, double ratio = 0.5, int? outputGenesNumber = null)
        {
            int genes1Count = genes1.Count;
            int genesCount = outputGenesNumber ?? genes1Count;
            int splitPosition = Convert.ToInt16(Math.Round(ratio * genesCount));
            if (splitPosition > genes1Count)
            {// in case of too big output number
                splitPosition = genes1Count;
            }
            List<Gene> res = new List<Gene>(genes1.Take(splitPosition));
            if (splitPosition > genes2.Count)
            {
                splitPosition = genes2.Count;
            }
            foreach (Gene gene in genes2.Skip(splitPosition))
            {
                res.Add((Gene) gene.Clone());
            }
            if (res.Count < genesCount)
            {
                int min = genes1[0].MinValue;
                int max = genes1[0].MaxValue;
                for (int i = res.Count; i < genesCount; i++)
                {
                    res.Add(new Gene(min, max));
                }
            }
            return res;
        }
        public static IndividualBase mergeIndividuals(IndividualBase parent1, IndividualBase parent2, string calculationMethod, double ratio = 0.5, int? outputGenesNumber = null)
        {
            int imageSize = parent1.imageSize;
            List<Gene> genes = new List<Gene>();
            IndividualBase res = AbstractFactory.CreateIndividual(imageSize, calculationMethod);
            res.genes = new List<Gene>(Merger.mergeGenes(parent1.genes, parent2.genes, ratio, outputGenesNumber));
            return res;
        }
    }
}
