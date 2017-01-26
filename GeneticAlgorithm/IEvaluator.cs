using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
	public interface IEvaluator
	{
		double calculateFitness(IndividualBase ind);
		double getMaxScore();
		List<int> getSampleImage(); 
        void closeDevice();
	}
}
