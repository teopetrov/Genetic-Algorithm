using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
	public interface IAlgorithm
	{
		void generateNewPopulation();
		void compute();
		int getProgress();
	}
}
