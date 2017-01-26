using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    static class Mutator
    {
        public static void mutatePopulation(Population pop, double mutatationPercent)
        {
            int individualsCount = pop.getIndividualsCount();
            int genesCount = pop.individuals[0].genes.Count;
            int mutationNumber = (int)Math.Round(mutatationPercent * individualsCount / 100);
            for (int i = 0; i < mutationNumber; i++)
            {
                Mutator.mutateIndividual(pop.individuals[Utilities.RandomNumber(0, individualsCount)], Utilities.RandomNumber(genesCount));
            }
        }
        public static void mutateIndividual(IndividualBase ind, double mutatationNumber)
        {
            int genesCount = ind.genes.Count;
            for (int i = 0; i < mutatationNumber; i++)
            {
                Mutator.mutateGene(ind.genes[Utilities.RandomNumber(0, genesCount)]);
            }
        }

        public static void mutateGene(Gene gene)
        {
            gene.setRandomValue();
        }
    }
}
