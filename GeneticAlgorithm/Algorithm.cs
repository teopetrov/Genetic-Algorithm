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

namespace GeneticAlgorithm
{
    class Algorithm
    {

        public void prepareField()
        {
            Functions.generateRandomImage().Save("test.jpg", ImageFormat.Jpeg);
        }

        public static int calculateFitness(Individual ind)
        {
            int res = 0;
            for (int i = 0; i < Parameters.getRadius(); i++)
            {
                res += ind.points[i];
            }
            return res;
        }


        public static Population generateNewPopulation(Population pop)
        {
            Population newPopulation = new Population();
            Random rand = new Random();
            string selectionType = Parameters.getSelectionMethod();
            newPopulation.individuals.AddRange(pop.selectIndividuals(Parameters.getPopulationSize() * (100 - Parameters.getMergePercent()) / 100));
            int populatedIndividuals = newPopulation.getIndividualsCount();
            int iterator = populatedIndividuals;
            for (; iterator < Parameters.getPopulationSize(); iterator++)
            {
                newPopulation.addIndividual(Individual.mergeIndividuals(newPopulation.getIndividualById(rand.Next(populatedIndividuals)),
                                            newPopulation.getIndividualById(rand.Next(populatedIndividuals))));
            }
            newPopulation.mutate();
            newPopulation.calculateFitnesses();
            newPopulation.count = pop.count + 1;
            return newPopulation;
        }

        public static bool checkStopAlgorithm(Population pop, string stopCondition, float stopValue)
        {
            switch (stopCondition)
            {
                case "generations":
                    if (pop.count < stopValue)
                    {
                        return false;
                    }
                    return true;
                case "percent":
                    if (pop.getBestIndividual().getFitnessPercentFromMax() >= stopValue)
                    {
                        return true;
                    }
                    return false;
                default:
                    return true;
            }
        }
        public void compute(bool graphicResults = false)
        {
            Population pop = new Population();
            int populationSize = Parameters.getPopulationSize();
            float stopValue = Parameters.getStopValue();
            for (int i = 0; i < populationSize; i++)
            {
                pop.addIndividual(Individual.generateRandomIndividual());
            }
            pop.calculateFitnesses();
            ProgressBar bar = (ProgressBar)Application.OpenForms["Home"].Controls["ProgressBarAlgorithm"];
            bar.Invoke((MethodInvoker)(delegate
            {                
                bar.Maximum = Convert.ToInt16(stopValue);
            }));

            //graphic            
            Chart chartResults = (Chart)Application.OpenForms["Home"].Controls["chartResults"];
            bool realTimeGraphic = ((CheckBox)Application.OpenForms["Home"].Controls["checkBoxRealTimeGraphic"]).Checked;
            List<float> results = new List<float>();
            if (graphicResults && realTimeGraphic)
            {
                chartResults.Invoke((MethodInvoker)delegate
                {
                    chartResults.Series[0].Points.Clear();
                });
            }
            //end of graphic

            //algorithm cycle
            Stopwatch timer = new Stopwatch();
            string stopCondition = Parameters.getStopCondition();
            timer.Start();
            while (!Algorithm.checkStopAlgorithm(pop, stopCondition, stopValue))
            {
                Label lblCurrentBest = (Label)Application.OpenForms["Home"].Controls["lblCurrentBest"];
                lblCurrentBest.Invoke((MethodInvoker)(() => lblCurrentBest.Text = "Current best result: " +
                                                            pop.getBestIndividual().getFitnessPercentFromMax().ToString() + "%"));
                float currentMax = pop.getBestIndividual().getFitnessPercentFromMax();
                if (graphicResults)
                {
                    if (realTimeGraphic)
                    {
                        chartResults.Invoke((MethodInvoker)delegate
                        {
                            chartResults.Series[0].Points.Add(currentMax);
                        });
                    }
                    else
                    {
                        results.Add(currentMax);
                    }
                }
                pop = Algorithm.generateNewPopulation(pop);
                bar.Invoke((MethodInvoker)(delegate
                {
                    switch (Parameters.getStopCondition())
                    {
                        case "generations":
                            bar.Increment(1);
                            break;
                        case "percent":
                            bar.Value = Convert.ToInt16(currentMax);
                            break;
                        default:
                            break;
                    }
                }));
            }
            timer.Stop();
            //end of algorithm cycle

            //graphic  
            if (graphicResults && !realTimeGraphic)
            {
                chartResults.Invoke((MethodInvoker)delegate
                {
                    chartResults.Series[0].Points.Clear();
                });
                foreach (var res in results)
                {
                    chartResults.Invoke((MethodInvoker)delegate
                    {
                        chartResults.Series[0].Points.AddY(res);
                    });
                }
            }
            //end of graphic

            //results
            TimeSpan time = TimeSpan.FromMilliseconds(timer.ElapsedMilliseconds);
            Individual best = pop.getBestIndividual();
            best.drawImage((Panel)Application.OpenForms["Home"].Controls["panelResult"]);
            Control txtResults = Application.OpenForms["Home"].Controls["txtResults"];
            txtResults.Invoke((MethodInvoker)(() => txtResults.Text = Functions.getResultText(pop, stopCondition, time)
                                                                        + Environment.NewLine + txtResults.Text));
            //end of results
        }

    }





}

