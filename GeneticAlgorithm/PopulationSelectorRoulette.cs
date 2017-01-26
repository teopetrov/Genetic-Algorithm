using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm;

namespace SelectionMethods
{
    [Status(Utilities.DevelopementStatus.Active)]
    [DDL("PopulationSelectorRoulette", "Roulette wheel")]
    class PopulationSelectorRoulette : IPopulationSelector
	{
		public void reducePopulation(Population pop, int killCount)
		{
			int popCount = pop.individuals.Count;
			if (popCount == 0)
			{
				return;
			}
			for (int i = 0; i < killCount; i++)
			{
				int target = Utilities.RandomNumber((int)Math.Ceiling(pop.getWorstIndividual().getFitness()), (int)Math.Floor(pop.getBestIndividual().getFitness()));
				int randIndex = Utilities.RandomNumber(0, pop.individuals.Count); ;
				while (pop.individuals[randIndex].getFitness() > target)
				{
					randIndex = Utilities.RandomNumber(0, pop.individuals.Count);
				}
				pop.individuals.RemoveAt(randIndex);
			}
		}
	}
}
