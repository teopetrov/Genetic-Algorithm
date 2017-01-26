//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace GeneticAlgorithm
//{
//    public class Individual2 : Individual
//    {
//        public float fitness = 0;
//        public List<int> points;
//        protected static Random rand = new Random();
//        public const int pointMaxValue = 256;
//        public const int pointMinValue = 0;
//        protected int imgSize;
//        public Individual2(int size)
//        {
//            this.imgSize = size;
//            this.points = new List<int>();
//            for (int i = 0; i < this.imgSize; i++)
//            {
//                this.points.Add(rand.Next(pointMaxValue));
//            }
//        }
//        public void setFitness(IEvaluator ev)
//        {
//            this.fitness = ev.calculateFitness(this);
//        }
//        public float getFitness()
//        {
//            return this.fitness;
//        }
//        public int CompareTo(Individual other)
//        {
//            return this.getFitness().CompareTo(other.getFitness());
//        }

//        public override void generatePoints()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
