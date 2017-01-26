using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgorithm
{
    public partial class AlgorithmForm : Form
    {
        AlgorithmBase algorithm;
        bool firstTime = true;
        public AlgorithmForm()
        {
            InitializeComponent();
            initChart();
        }

        public AlgorithmForm(AlgorithmBase alg)
        {
            InitializeComponent();
            initSettings(alg);
            initChart();
            algorithmProgress.Maximum = alg.getProgressBarMaximum();
        }

        public void initChart()
        {
            chartResults.Series.Clear();
            chartResults.Series.Add(new Series(""));
            chartResults.Series[0].ChartType = SeriesChartType.Line;
            chartResults.Series[0].IsVisibleInLegend = false;
            chartResults.ChartAreas[0].AxisY.Minimum = 0;
            chartResults.ChartAreas[0].AxisY.Maximum = 100;
        }

        public void initSettings(AlgorithmBase alg)
        {
            this.algorithm = alg;
            lblStopCond.Text = alg.stopCondition;
            lblStopVal.Text = alg.stopValue.ToString();
            lblPopSize.Text = alg.populationSize.ToString();
            lblMergePercent.Text = alg.mergePercent.ToString();
            lblMutPercent.Text = alg.mutationPercent.ToString();
            lblSelMethod.Text = alg.selectionMethod;
            lblImgSize.Text = alg.imageSize.ToString();
            lblCurrentGeneration.Text = "0";

            alg.generationComputed += updateUI;
            alg.problemSolved += completed;
        }

        public void resetForm()
        {
            chartResults.Series[0].Points.Clear();
        }

        public void startAlgorithm()
        {
            resetForm();
            Thread activeThread = new Thread(() =>
            {
                algorithm.compute();
                SystemSounds.Asterisk.Play();
            });
            activeThread.Start();
            btnRunAgain.Enabled = false;
            algorithmProgress.Value = 0;
        }

        public void setCheckboxes(bool chart, bool realtimeChart, bool realtimeImage)
        {
            chkChart.Checked = chart;
            chkRealtimeChart.Checked = realtimeChart;
            chkRealtimeImage.Checked = realtimeImage;
        }

        public void completed(AlgorithmBase alg)
        {
            updateUI(alg);
            this.Invoke((MethodInvoker)(() =>
            {
                btnRunAgain.Enabled = true;
                Image.Draw1D(pnlImage, alg.currentPopulation.getBestIndividual().pixels);
            }
            ));
        }

        public void updateUI(AlgorithmBase alg)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                algorithmProgress.Value = alg.getProgress();
                updateChart(alg);
                updateImage(alg);
                lblResult.Text = alg.getCurrentMaxFitness().ToString() + " %";
                lblCurrentGeneration.Text = alg.populationCounter.ToString();
            }
            ));

        }

        public void updateChart(AlgorithmBase alg)
        {
            if (chkChart.Checked && chkRealtimeChart.Checked)
            {
                chartResults.Series[0].Points.Add(alg.getCurrentMaxFitness());
            }
            if (alg.shouldStop)
            {
                chartResults.Series[0].Points.Clear();
                foreach (float res in alg.results)
                {
                    chartResults.Series[0].Points.AddY(res);
                }
            }
        }

        public void updateImage(AlgorithmBase alg)
        {
            if (chkRealtimeImage.Checked)
            {
                Image.Draw1D(pnlImage, alg.currentPopulation.getBestIndividual().pixels);
            }
            if (this.firstTime)
            {
                this.firstTime = false;
                Image.Draw1D(pnlTargetImage, alg.evaluator.getSampleImage());
            }
        }

        private void  AlgorithmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStop_Click(null, null);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnRunAgain.Enabled = true;
            algorithm.requestStop();
        }

        private void btnRunAgain_Click(object sender, EventArgs e)
        {
            algorithm.reset();
            startAlgorithm();
        }

        private void chkChart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChart.Checked)
            {
                chkRealtimeChart.Enabled = true;
            }
            else
            {
                chkRealtimeChart.Enabled = false;
            }
        }

        public void showSmartModeMessage(bool show = true) {
            this.Invoke((MethodInvoker)(()=>{ lblSmartMode.Visible = show; }));
        }
    }
}
