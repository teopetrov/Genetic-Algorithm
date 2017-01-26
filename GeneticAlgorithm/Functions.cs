using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    class Functions
    {
        public static int[][] generateRandomBits()
        {
            int width = Parameters.getImageWidth();
            int height = Parameters.getImageHeight();
            int[][] result = new int[width][];
            for (int i = 0; i < width; i++)
            {
                result[i] = new int[height];
            }
            Random rand = new Random();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    result[i][j] = rand.Next(256);
                }
            }
            return result;
        }
        public static Image generateRandomImage()
        {
            return Functions.generateImageFromBits(Functions.generateRandomBits());
        }
        public static Image generateImageFromBits(int[][] bits)
        {
            int width = bits.Length;
            int height = bits[0].Length;
            int color = 0;
            Bitmap bmp = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    color = bits[i][j];
                    bmp.SetPixel(i, j, Color.FromArgb(color, color, color));
                }
            }
            return bmp;
            //bmp.Save("test.jpg", ImageFormat.Jpeg);
        }

        public static int[][] mergeBits(int[][] first, int[][] second, int x = 0, int y = 0)
        {
            int width = first.Length;
            int height = first[0].Length;
            if (x == 0)
            {
                x = width / 2;
            }
            if (y == 0)
            {
                y = height / 2;
            }
            int[][] result = new int[width][];
            for (int i = 0; i < width; i++)
            {
                result[i] = new int[height];
            }
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (i < x)
                    {
                        result[i][j] = first[i][j];
                    }
                    else if (i == x)
                    {
                        if (y < height)
                        {
                            result[i][j] = first[i][j];
                        }
                        else
                        {
                            result[i][j] = second[i][j];
                        }
                    }
                    else
                    {
                        result[i][j] = second[i][j];
                    }
                }
            }
            return result;
        }

        public static string getResultText(Population pop, string stopCondition, TimeSpan time)
        {
            string res = "";
            switch (stopCondition)
            {
                case "generations":
                    res += "Generations cycle; " + "Method: " + Parameters.getSelectionMethod();
                    res += ": Generations: " + Parameters.getStopValue().ToString() + "; Population size: "
                            + Parameters.getPopulationSize().ToString() + "; Merge: " + Parameters.getMergePercent() + "; Mutation: "
                            + Parameters.getMutationPercent() + "; (Image: " + Parameters.getImageWidth() + "/" + Parameters.getImageHeight()
                            + ", radius:" + Parameters.getRadius() + ")";
                    res += " => Time: " + time.ToString();
                    res += " => Result: " + pop.getBestIndividual().getFitnessPercentFromMax().ToString() + "%";
                    break;
                case "percent":
                    res += "Desired percent; " + "Method: " + Parameters.getSelectionMethod();
                    res += ": Percent goal: " + Parameters.getStopValue() + "; Population size: "
                            + Parameters.getPopulationSize().ToString() + "; Merge: " + Parameters.getMergePercent() + "; Mutation: "
                            + Parameters.getMutationPercent() + "; (Image: " + Parameters.getImageWidth() + "/" + Parameters.getImageHeight()
                            + ", radius:" + Parameters.getRadius() + ")";
                    res += " => Time: " + time.ToString();
                    res += " => Needed generations: " + pop.count.ToString();
                    break;
                default:
                    res = "";
                    break;
            }
            return res;
        }
    }
}
