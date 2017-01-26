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
using SelectionMethods;
using Algorithms;
using System.IO;
using System.Xml;

namespace GeneticAlgorithm
{
    public partial class Home : Form
    {
        public Thread activeThread;
        public Home()
        {            
            InitializeComponent();
            //DDL evaluators
            ddlEvaluator.DataSource = new BindingSource(Parameters.getDDLEvaluators(), null);
            ddlEvaluator.DisplayMember = "Value";
            ddlEvaluator.ValueMember = "Key";
            ddlEvaluator.SelectedIndex = 1;
            //DDL stop conditions
            ddlStopCondition.DataSource = new BindingSource(Parameters.getDDLAlgorithmStopConditions(), null);
            ddlStopCondition.DisplayMember = "Value";
            ddlStopCondition.ValueMember = "Key";
            ddlStopCondition.SelectedIndex = 0;
            //DDL selection methods
            ddlSelection.DataSource = new BindingSource(Parameters.getDDLSelectionMethods(), null);
            ddlSelection.DisplayMember = "Value";
            ddlSelection.ValueMember = "Key";
            ddlSelection.SelectedIndex = 0;
            //DDL calculation methods
            ddlCalculationMethod.DataSource = new BindingSource(Parameters.getDDLPixelGenerators(), null);
            ddlCalculationMethod.DisplayMember = "Value";
            ddlCalculationMethod.ValueMember = "Key";
            ddlCalculationMethod.SelectedIndex = 0;
            //graphic
            chartResults.Series.Clear();
            chartResults.Series.Add(new Series(""));
            chartResults.Series[0].ChartType = SeriesChartType.Line;
            chartResults.Series[0].IsVisibleInLegend = false;
            chartResults.ChartAreas[0].AxisY.Minimum = 0;
            chartResults.ChartAreas[0].AxisY.Maximum = 100;
        }

        #region Algorithm work
        public void algorithmStart(AlgorithmBase alg)
        {
            if (Parameters.getCheckBoxGraphic() && Parameters.getCheckBoxRealTimeGraphic())
            {
                chartResults.Invoke((MethodInvoker)delegate
                {
                    chartResults.Series[0].Points.Clear();
                });
            }
        }

        public void UpdateDataGrid(AlgorithmBase alg)
        {
            List<object> cells = new List<object>();
            TimeSpan time = TimeSpan.FromMilliseconds(alg.timer.ElapsedMilliseconds);
            cells.Add(alg.getFitnessPercentFromMax(alg.currentPopulation.getBestIndividual()));
            cells.Add(alg.populationCounter);
            cells.Add(alg.popSelector.GetType().ToString());
            cells.Add(alg.stopCondition);
            cells.Add(alg.mergePercent);
            cells.Add(alg.mutationPercent);
            cells.Add(alg.imageSize);
            cells.Add(alg.populationSize);
            cells.Add(time);

            dataGridViewResults.Rows.Add(cells.ToArray());
            dataGridViewResults.Rows[dataGridViewResults.Rows.Count - 1].Tag = alg;
        }

        public void updateChart(List<double> points)
        {
            chartResults.Series[0].Points.Clear();
            foreach (float res in points)
            {
                chartResults.Series[0].Points.AddY(res);
            }
        }

        public void algorithmFinished(AlgorithmBase alg)
        {
            if (Parameters.getCheckBoxGraphic() && !Parameters.getCheckBoxRealTimeGraphic())
            {
                chartResults.Invoke((MethodInvoker)delegate
                {
                    updateChart(alg.results);
                });

            }
            //results
            TimeSpan time = TimeSpan.FromMilliseconds(alg.timer.ElapsedMilliseconds);
            IIndividual best = alg.currentPopulation.getBestIndividual();
            Image.Draw1D(panelResult, alg.currentPopulation.getBestIndividual().pixels);

            dataGridViewResults.Invoke((MethodInvoker)(() => UpdateDataGrid(alg)));

            Button btnStart = (Button)Application.OpenForms["Home"].Controls["btnTestAlgorithm"];
            btnStart.Invoke((MethodInvoker)(() => btnStart.Enabled = true));

        }
        #endregion

        #region Event handlers
        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnTestAlgorithm_Click(object sender, EventArgs e)
        {
            AlgorithmBase genetic = AbstractFactory.CreateAlgorithm();
            genetic.problemSolved += algorithmFinished;
            AlgorithmForm f = new AlgorithmForm(genetic);
            f.Show();
            f.setCheckboxes(Parameters.getCheckBoxGraphic(), Parameters.getCheckBoxRealTimeGraphic(), Parameters.getCheckBoxRealTimeGraphic());
            f.startAlgorithm();
        }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            this.dataGridViewResults.Rows.Clear();
        }

        private void btnTestModulator_Click(object sender, EventArgs e)
        {
            int monitorNumber = Parameters.getModulatorMonitorNumber();
            if (monitorNumber >= 0 && Screen.AllScreens.Count() > monitorNumber)
            {
                FullScreenImage form = new FullScreenImage();
                form.Location = Screen.AllScreens[monitorNumber].WorkingArea.Location;
                form.FormBorderStyle = FormBorderStyle.None;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
                form.drawImage(Utilities.getFocusingMirror(200));
                btnEndTest.Enabled = true;
            }
            else
            {
                MessageBox.Show(String.Format("The monitor number {0} is not available", monitorNumber.ToString()), "Wrong monitor number.");
            }
        }
        private void btnEndTest_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FullScreenImage"] != null)
            {
                Application.OpenForms["FullScreenImage"].Close();
            }
            btnEndTest.Enabled = false;
        }
        private void btnAddParameter_Click(object sender, EventArgs e)
        {
            int newLineMargin = 22;
            int parameterNumber = ((panelParameters.Controls.Count - 2) / 3) + 1;

            CheckBox checkBox = new CheckBox();
            CheckBox lastCheckBox = (CheckBox)(panelParameters.Controls["checkBoxA" + (parameterNumber - 1).ToString()]);
            checkBox.Name = "checkBoxA" + parameterNumber.ToString();
            checkBox.Text = "a" + parameterNumber.ToString();
            checkBox.Location = new Point(lastCheckBox.Left, lastCheckBox.Top + newLineMargin);
            panelParameters.Controls.Add(checkBox);

            TextBox txtMin = new TextBox();
            TextBox lastTxtMin = (TextBox)(panelParameters.Controls["txtA" + (parameterNumber - 1).ToString() + "Min"]);
            txtMin.Name = "txtA" + parameterNumber.ToString() + "Min";
            txtMin.Width = lastTxtMin.Width;
            txtMin.Height = lastTxtMin.Height;
            txtMin.Text = "-1";
            txtMin.Location = new Point(lastTxtMin.Left, lastTxtMin.Top + newLineMargin);
            panelParameters.Controls.Add(txtMin);
            panelParameters.Controls["txtA" + parameterNumber.ToString() + "Min"].BringToFront();

            TextBox txtMax = new TextBox();
            TextBox lastTxtMax = (TextBox)(panelParameters.Controls["txtA" + (parameterNumber - 1).ToString() + "Max"]);
            txtMax.Name = "txtA" + parameterNumber.ToString() + "Max";
            txtMax.Width = lastTxtMax.Width;
            txtMax.Height = lastTxtMax.Height;
            txtMax.Text = "1";
            txtMax.Location = new Point(lastTxtMax.Left, lastTxtMax.Top + newLineMargin);
            panelParameters.Controls.Add(txtMax);
        }
        private void checkBoxGraphic_CheckedChanged(object sender, EventArgs e)
        {
            if (Parameters.getCheckBoxGraphic())
            {
                checkBoxRealTimeGraphic.Enabled = true;
            }
            else
            {
                checkBoxRealTimeGraphic.Enabled = false;
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            string file = Path.Combine(Application.StartupPath, "results.xml");
            XmlDocument xml = new XmlDocument();
            if (File.Exists(file))
            {
                try
                {
                    xml.Load(file);
                }
                catch
                { }
            }

            if (xml.ChildNodes.Count == 0)
            {
                xml.AppendChild(xml.CreateElement("results"));
            }
            foreach (DataGridViewRow r in dataGridViewResults.Rows)
            {
                XmlElement node = xml.CreateElement("result");
                foreach (DataGridViewColumn c in dataGridViewResults.Columns)
                {
                    node.Attributes.Append(xml.CreateAttribute(c.Name));
                    node.Attributes[c.Name].Value = r.Cells[c.Name].Value.ToString();
                }
                xml.FirstChild.AppendChild(node);
            }
            xml.Save(file);
        }
        #endregion

        #region Grid 
        private void gridRowClicked(int index)
        {
            AlgorithmBase alg = (AlgorithmBase)dataGridViewResults.Rows[index].Tag;
            updateChart(alg.results);
            Image.Draw1D(panelResult, alg.currentPopulation.getBestIndividual().pixels);
        }

        private void dataGridViewResults_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewResults.SelectedRows.Count > 0)
            {
                gridRowClicked(dataGridViewResults.SelectedRows[0].Index);
            }
        }

        private void dataGridViewResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridRowClicked(e.RowIndex);
            AlgorithmBase alg = (AlgorithmBase)dataGridViewResults.Rows[e.RowIndex].Tag;
            updateChart(alg.results);
            Image.Draw1D(panelResult, alg.currentPopulation.getBestIndividual().pixels);
        }

        #endregion

        
    }
}
