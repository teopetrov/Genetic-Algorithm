using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Gene : ICloneable
    {
        public Gene(int min, int max) {
            this.MinValue = min;
            this.MaxValue = max;
            this.setRandomValue();
        }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Value { get; set; }
        public void setRandomValue()
        {
            this.Value = Utilities.RandomNumber(this.MinValue, this.MaxValue + 1);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
