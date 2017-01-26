using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    [Status(Utilities.DevelopementStatus.Active)]
    [DDL("EvaluatorLocal", "Local 1 dimension evaluator")]
    public class EvaluatorLocal : IEvaluator
	{
		List<int> sample = new List<int>();
		static Random rand = new Random();
		protected int imageSize = 0;

		public EvaluatorLocal(int imageSize) {
			this.imageSize = imageSize;
			this.sample = this.generateSampleImage();
		}
		public double getMaxScore()
		{
			return this.imageSize * Configuration.pixelMaxValue;
		}
		public double calculateFitness(IndividualBase ind)
		{
            double ret = 0;
			for (int i = 0; i < imageSize; i++)
			{
				ret += Configuration.pixelMaxValue - Math.Abs(ind.pixels[i] - sample[i]);
			}			
			return ret;
		}
		public List<int> getSampleImage()
		{
			return this.sample;
		}
		public List<int> generateSampleImage()
		{
            return Utilities.getFocusingMirror(this.imageSize);
		}
        public void closeDevice()
        {
        }
    }
}