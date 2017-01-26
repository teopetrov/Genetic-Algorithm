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
    [DDL("AlgorithmFullGenerationsCycle", "Full generations cycle")]
    public class AlgorithmFullGenerationsCycle : AlgorithmBase
	{

		public override void checkStopAlgorithm()
		{
			if (this.populationCounter >= this.stopValue)
			{
                this.shouldStop = true;	
			}
			
		}
				
		public override string getResultText()
		{
			string res = "";
			TimeSpan time = TimeSpan.FromMilliseconds(this.timer.ElapsedMilliseconds);
			res += "Generations cycle; " + "Method: " + Parameters.getSelectionMethod();
			res += ": Generations: " + Parameters.getStopValue().ToString() + "; Population size: "
							+ Parameters.getPopulationSize().ToString() + "; Merge: " + Parameters.getMergePercent() + "; Mutation: "
							+ Parameters.getMutationPercent() + "; (Image: " + Parameters.getImageSize()
							+ ")";
			res += " => Time: " + time.ToString();
			res += " => Result: " + this.getFitnessPercentFromMax(currentPopulation.getBestIndividual()).ToString() + "%";

			return res;
		}

		public override int getProgress()
		{
			return (int)Math.Round((this.populationCounter * 100 / this.stopValue));
		}
	}
}


