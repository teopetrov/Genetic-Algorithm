using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;

namespace GeneticAlgorithm
{
    public delegate void algorithmStateChanged(AlgorithmBase alg);

    public abstract class AlgorithmBase : IAlgorithm
    {
        public IPopulationSelector popSelector;
        public IPixelGenerator pixelGenerator;
        public IEvaluator evaluator;
        public Population currentPopulation = new Population();
        public IndividualBase bestOfAllTimeIndividual;
        public Stopwatch timer = new Stopwatch();
        public string stopCondition;
        public string selectionMethod;
        public string calculationMethod;
        public int populationCounter = 0;
        public int populationSize;
        public int imageSize;
        public double maxScore;
        public double stopValue;
        public double mergePercent;
        public double mutationPercent;
        public volatile bool shouldStop = false;
        public List<double> results = new List<double>();
        public delegate void stateChanged(IAlgorithm alg);
        public algorithmStateChanged generationComputed;
        public algorithmStateChanged alogirthmStart;
        public algorithmStateChanged problemSolved;

        public AlgorithmBase()
        {
            this.evaluator = AbstractFactory.CreateEvaluator(Parameters.getEvaluator());
            this.stopCondition = Parameters.getStopCondition();
            this.selectionMethod = Parameters.getSelectionMethod();
            this.calculationMethod = Parameters.getCalculationMethod();
            this.stopValue = Parameters.getStopValue();
            this.populationSize = Parameters.getPopulationSize();
            this.mergePercent = Parameters.getMergePercent();
            this.mutationPercent = Parameters.getMutationPercent();
            this.imageSize = Parameters.getImageSize();
            this.popSelector = AbstractFactory.CreatePopulationSelector(this.selectionMethod);
            this.pixelGenerator = AbstractFactory.CreatePixelGenerator(this.imageSize, this.calculationMethod);
            this.maxScore = this.getMaxScore();
        }
        public virtual void compute()
        {
            if (alogirthmStart != null)
            {
                alogirthmStart(this);
            }
            this.timer.Start();
            while (!shouldStop)
            {
                this.generateNewPopulation();
                if (generationComputed != null)
                {
                    generationComputed(this);
                }
                this.checkStopAlgorithm();
                this.results.Add(this.getFitnessPercentFromMax((IndividualBase)this.bestOfAllTimeIndividual));
            }
            timer.Stop();
            if (problemSolved != null)
            {
                this.evaluator.closeDevice();
                problemSolved(this);
            }
        }
        public void reset()
        {
            results = new List<double>();
            timer = new Stopwatch();
            populationCounter = 0;
            shouldStop = false;
            currentPopulation = new Population();
        }
        public virtual void generateNewPopulation()
        {
            this.currentPopulation = new Population(this.currentPopulation.individuals, this.evaluator);
            int individualsCount = this.currentPopulation.getIndividualsCount();
            bool isNew = (individualsCount == 0);
            int killNumber = Convert.ToInt16(this.mergePercent * this.populationSize / 100);
            if (!isNew)
            {
                this.popSelector.reducePopulation(this.currentPopulation, killNumber);
                individualsCount = this.currentPopulation.getIndividualsCount();
            }
            for (int i = this.currentPopulation.getIndividualsCount(); i < populationSize; i++)
            {
                if (isNew)
                {
                    this.currentPopulation.individuals.Add(AbstractFactory.CreateIndividual(this.imageSize, this.calculationMethod));
                }
                else if (this.currentPopulation.individuals.Count > 0)
                {
                    this.currentPopulation.individuals.Add(
                        this.mergeIndividuals(this.currentPopulation.individuals[Utilities.RandomNumber(individualsCount)], this.currentPopulation.individuals[Utilities.RandomNumber(individualsCount)])
                    );
                }
            }
            this.mutatePopulation();
            this.currentPopulation.generatePixelsOfAllIndividuals(this.pixelGenerator);
            this.currentPopulation.calculateFitnesses();
            this.saveBestIndividual(this.currentPopulation.getBestIndividual());
            this.populationCounter++;
        }
        public void mutatePopulation()
        {
            Mutator.mutatePopulation(this.currentPopulation, this.mutationPercent);
        }
        public IndividualBase mergeIndividuals(IndividualBase parent1, IndividualBase parent2)
        {
            return Merger.mergeIndividuals(parent1, parent2, this.calculationMethod);
        }

        public double getMaxScore()
        {
            return this.evaluator.getMaxScore();
        }

        public double getFitnessPercentFromMax(IndividualBase ind)
        {
            return ind.getFitness() * 100 / this.maxScore;
        }

        public double getCurrentMaxFitness()
        {
            return getFitnessPercentFromMax(currentPopulation.getBestIndividual());
        }

        public void requestStop()
        {
            shouldStop = true;
        }

        public virtual int getProgressBarMaximum()
        {
            return 100;
        }
        protected virtual void saveBestIndividual(IndividualBase currentBestIndividual) {
            if (this.bestOfAllTimeIndividual == null || this.bestOfAllTimeIndividual.getFitness() < currentBestIndividual.getFitness())
            {
                bestOfAllTimeIndividual = (IndividualBase) currentBestIndividual.Clone();
            }
            if (this.bestOfAllTimeIndividual != null)
            {
                this.bestOfAllTimeIndividual.setFitness(this.evaluator.calculateFitness(this.bestOfAllTimeIndividual));
                this.currentPopulation.individuals.Add((IndividualBase)this.bestOfAllTimeIndividual.Clone());
                this.currentPopulation.individuals.RemoveAt(0);
            }
        }
        public abstract string getResultText();
        public abstract void checkStopAlgorithm();
        public abstract int getProgress();
    }
}
