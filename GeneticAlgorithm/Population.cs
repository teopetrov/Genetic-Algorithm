using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Population
    {
        public List<IndividualBase> individuals = new List<IndividualBase>();
        public IEvaluator evaluator;
        public Population(List<IndividualBase> inds, IEvaluator ev)
        {
            this.individuals = new List<IndividualBase>(inds);
            evaluator = ev;
        }
        public Population() { }
        public int getIndividualsCount()
        {
            return this.individuals.Count;
        }
        public IndividualBase getWorstIndividual()
        {
            //sortIndividuals();
            return this.individuals.First();
        }
        //individuals must be always sorted to return correct best individual
        public IndividualBase getBestIndividual()
        {
            //sortIndividuals();
            return this.individuals.Last();
        }
        public void generatePixelsOfAllIndividuals(IPixelGenerator pixelGenerator)
        {
            foreach (IndividualBase ind in this.individuals)
            {
                ind.generatePixels(pixelGenerator);
            }
        }
        public void calculateFitnesses()
        {
            foreach (IndividualBase ind in this.individuals)
            {
                ind.setFitness(this.evaluator.calculateFitness(ind));
            }
            this.individuals.Sort();
        }
        public double sumFitnesses()
        {
            double sum = 0;
            foreach (IndividualBase ind in individuals)
            {
                sum += ind.getFitness();
            }
            return sum;
        }
    }
}
