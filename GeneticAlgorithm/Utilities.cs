using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    static class Utilities
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public enum DevelopementStatus { Active, Inactive, Draft, Archived };
        public static int RandomNumber(int max)
        {
            lock (syncLock)
            {
                return random.Next(max);
            }
        }
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { 
                return random.Next(min, max);
            }
        }
        public static int factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * factorial(number - 1);
            }
        }
        public static List<int> getFocusingMirror(int imageSize)
        {
            List<int> ret = new List<int>();
            decimal step = Convert.ToDecimal(255) / imageSize;
            int color = 0;
            for (int i = 0; i < imageSize / 2; i++)
            {
                ret.Add(color);
                color = Convert.ToInt16(color + step);
            }
            List<int> image = new List<int>(ret);
            ret.Reverse();
            image.AddRange(ret);
            return image;
        }
    }
}
