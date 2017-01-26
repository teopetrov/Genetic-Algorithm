using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm;

namespace SelectionMethods
{
    [Status(Utilities.DevelopementStatus.Active)]
    [DDL("PopulationSelectorBest", "Pick best ones")]
    class PopulationSelectorBest : IPopulationSelector
	{
		public void reducePopulation(Population pop, int killCount)
		{
			pop.individuals = pop.individuals.Skip(killCount).ToList();
		}
	}
}
