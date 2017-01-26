using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    [Status(Utilities.DevelopementStatus.Inactive)]
    [DDL("EvaluatorLocal2d", "Local evaluator 2d")]
    public class EvaluatorLocal2d : IEvaluator
	{
		List<int> sample = new List<int>();
		static Random rand = new Random();
		protected int imgSize = 0;

		public EvaluatorLocal2d(int size) {
			this.imgSize = size;
			this.sample = this.generateSampleImage();
		}

		public double getMaxScore()
		{
			return imgSize * Configuration.pixelMaxValue;
		}

		public double calculateFitness(IndividualBase ind)
		{
            double ret = 0;
			for (int i = 0; i < imgSize; i++)
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
			return getWhite();

			switch (rand.Next(0, 5)) {
				case 1:
					return getBlack();
					break;
				case 2:
					return getGradientVertical();
					break;
				case 3:
					return getGradientHorisontal();
					break;
			}
			return getWhite();
		}
		protected List<int> getWhite()
		{
			List<int> ret = new List<int>();
			for (int i = 0; i < imgSize; i++)
			{
				ret.Add(Configuration.pixelMaxValue - 1);
			}

			return ret;
		}
		protected List<int> getBlack()
		{
			List<int> ret = new List<int>();
			for (int i = 0; i < imgSize; i++)
			{
				ret.Add(Configuration.pixelMinValue);
			}

			return ret;
		}
		protected List<int> getGradientVertical()
		{
			List<int> ret = new List<int>();
			int rows = (int)Math.Floor(Math.Sqrt(imgSize));
			int step = (int)Math.Floor((float)(Configuration.pixelMaxValue / rows));
			int lastColor = 0;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					lastColor = i * step;
					ret.Add(lastColor);
				}
			}

			return appendRest(lastColor, ret);
		}
		protected List<int> getGradientHorisontal()
		{
			List<int> ret = new List<int>();
			int rows = (int)Math.Floor(Math.Sqrt(imgSize));
			int step = (int)Math.Floor((float)(Configuration.pixelMaxValue / rows));
			int lastColor = 0;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					lastColor = j * step;
					ret.Add(lastColor);
				}
			}

			return appendRest(lastColor, ret);
		}

		protected List<int> getWhiteTarget()
		{
			List<int> ret = new List<int>();
			int rows = (int)Math.Floor(Math.Sqrt(imgSize));
			int step = (int)Math.Floor((float)(Configuration.pixelMaxValue / rows));
			int lastColor = 0;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					lastColor = j * step;
					ret.Add(lastColor);
				}
			}

			return appendRest(lastColor, ret);
		}

		protected List<int> appendRest(int color, List<int> points)
		{
			int c = imgSize - points.Count;
			for (int i = 0; i < c; i++) {
				points.Add(color);
			}

			return points;
		}

        public void closeDevice()
        {
        }
    }
}
