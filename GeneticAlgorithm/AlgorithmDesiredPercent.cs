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
    [DDL("AlgorithmDesiredPercent", "Desired percent")]
	public class AlgorithmDesiredPercent : AlgorithmBase
	{
		public override void checkStopAlgorithm()
		{
			if (this.populationCounter != 0 && this.getFitnessPercentFromMax(this.currentPopulation.getBestIndividual()) >= stopValue )
			{
                this.shouldStop = true;
            }
		}

        public override int getProgressBarMaximum()
        {
            return (int)this.stopValue;
        }
        public override string getResultText()
		{
			string res = "";
			TimeSpan time = TimeSpan.FromMilliseconds(this.timer.ElapsedMilliseconds);
			res += "Desired percent; " + "Method: " + Parameters.getSelectionMethod();
			res += "; Population size: "
							+ Parameters.getPopulationSize().ToString() + "; Merge: " + Parameters.getMergePercent() + "; Mutation: "
							+ Parameters.getMutationPercent() + "; (Image: " + Parameters.getImageSize()
							+ ")";
			res += " => Time: " + time.ToString();
			res += " => Result: " + this.populationCounter + " populations";

			return res;
		}

		public override int getProgress()
		{
			return (int)Math.Round(this.getFitnessPercentFromMax(this.currentPopulation.getBestIndividual()));
		}
		}
}

