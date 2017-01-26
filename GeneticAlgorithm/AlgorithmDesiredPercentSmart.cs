using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GeneticAlgorithm;


namespace Algorithms
{
    [Status(Utilities.DevelopementStatus.Active)]    
    [DDL("AlgorithmDesiredPercentSmart", "Desired percent SMART")]
    public class AlgorithmDesiredPercentSmart : AlgorithmDesiredPercent
    {
        public int lastSmartMode = 0;
        public int stuckLimit = 20;

        public override void compute()
        {
            if (alogirthmStart != null)
            {
                alogirthmStart(this);
            }
            this.timer.Start();
            while (!shouldStop)
            {
                this.generateNewPopulation();    
                this.results.Add(this.getFitnessPercentFromMax(this.currentPopulation.individuals.Last()));
                this.checkSmartMode();
                this.checkStopAlgorithm();
                if (generationComputed != null)
                {
                    generationComputed(this);
                }
            }
            timer.Stop();
            if (problemSolved != null)
            {
                problemSolved(this);
            }
        }

        public void checkSmartMode()
        {
            if (this.populationCounter >= this.stuckLimit && this.results.Last() == this.results[this.populationCounter - this.stuckLimit] && (this.populationCounter - this.lastSmartMode > this.stuckLimit))
            {
                this.activateSmartMode();
            }
        }

        public void activateSmartMode()
        {
            AlgorithmForm form = ((AlgorithmForm)Application.OpenForms["AlgorithmForm"]);
            form.showSmartModeMessage();
            this.lastSmartMode = populationCounter;
            int artificialMutateNumber = Convert.ToInt16(this.populationSize * 0.8);
            for (int i = 0; i < artificialMutateNumber; i++)
            {
                Mutator.mutateIndividual(this.currentPopulation.individuals[this.populationSize - 1 - i], 0.8);
            }
            this.currentPopulation.calculateFitnesses();
            this.saveBestIndividual(this.currentPopulation.getBestIndividual());
            this.results[this.results.Count - 1] = this.getFitnessPercentFromMax(this.currentPopulation.getBestIndividual());
            form.showSmartModeMessage(false);
        }

    }
}

