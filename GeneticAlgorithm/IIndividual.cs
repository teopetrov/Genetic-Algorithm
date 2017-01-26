using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
	public interface IIndividual : IComparable
    {
        List<int> getPixels(IPixelGenerator pixelGenerator);
        void setFitness(double fitness);
        double getFitness();          
	}
}
