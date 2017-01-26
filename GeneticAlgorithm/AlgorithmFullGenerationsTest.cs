//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Drawing;
//using System.Drawing.Imaging;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;
//using Algorithms;
//using SelectionMethods;

//namespace GeneticAlgorithm
//{

//  [Status(Utilities.DevelopementStatus.Draft)]
//	public class AlgorithmFullGenerationsCycleLiubo : AlgorithmFullGenerationsCycle
//	{
//		Individual bestIndivid = null;
//		int notChangedSinse = 0;
//		double originalMutationPercent = 0;
//		int increaseMutationAfter = 10;
//		int generationsUsingIncreasedMutation = 10;
//		int increasedMutationsCount = 0;

//		public AlgorithmFullGenerationsCycleLiubo() : base()
//		{
//			originalMutationPercent = mutationPercent;
//		}

//		public override void generateNewPopulation()
//		{
//			this.currentPopulation = new Population(this.currentPopulation.individuals, this.evaluator);
//			bool isNew = (currentPopulation.getIndividualsCount() == 0);
//			int killNumber = Convert.ToInt16((100 - this.mergePercent) * this.populationSize / 100);
//			if (!isNew)
//			{
//				this.currentPopulation = this.popSelector.reducePopulation(this.currentPopulation, killNumber);
//				this.currentPopulation = this.popSelector.reducePopulation(this.currentPopulation, killNumber);
//			}

//			for (int i = this.currentPopulation.individuals.Count; i < populationSize; i++)
//			{
//				if (isNew)
//				{
//					this.currentPopulation.individuals.Add(this.createIndividual());
//				}
//				else if (this.currentPopulation.individuals.Count > 0)
//				{
//					this.currentPopulation.individuals.Add(
//						this.createIndividual(this.currentPopulation.individuals[rand.Next(currentPopulation.individuals.Count)], this.currentPopulation.individuals[rand.Next(currentPopulation.individuals.Count)])
//					);
//				}
//			}

//			if ((populationCounter - notChangedSinse) >= increaseMutationAfter)
//			{
//				mutationPercent += originalMutationPercent / 100 * 50;
//				notChangedSinse = populationCounter;
//			}
//			else if (mutationPercent != originalMutationPercent && generationsUsingIncreasedMutation <= increasedMutationsCount)
//			{
//				mutationPercent = originalMutationPercent;
//				increasedMutationsCount = 0;
//			}
//			else if (mutationPercent != originalMutationPercent) {
//				increasedMutationsCount++;
//			}

//			/*
//			if (mutationPercent > 50)
//			{
//				mutationPercent = originalMutationPercent;
//				notChangedSinse = populationCounter;
//				mutationPercent = originalMutationPercent;
//			}
//			*/

//			this.mutatePopulation();
//			this.currentPopulation.calculateFitnesses();
//			this.populationCounter++;
//			if (bestIndivid == null ||
//					this.bestIndivid.getFitness() < this.currentPopulation.getBestIndividual().getFitness())
//			{
//				bestIndivid = new Individual(this.imageSize);
//				bestIndivid.points = new List<int>(currentPopulation.getBestIndividual().points);
//				bestIndivid.setFitness(this.evaluator);
//				notChangedSinse = populationCounter;
//				mutationPercent = originalMutationPercent;
//			}
//		}

//		protected void mutateBest()
//		{
//			try
//			{
//				List<Individual> tmp = new List<Individual>(this.currentPopulation.individuals.Skip(this.currentPopulation.individuals.Count - 20));
//				foreach (Individual ind in tmp)
//				{
//					this.mutate(ind);
//				}
//				this.currentPopulation.individuals.AddRange(tmp);
//			}
//			catch
//			{ }
//		}
//	}
//}


