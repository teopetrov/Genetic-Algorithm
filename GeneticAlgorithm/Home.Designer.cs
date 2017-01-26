namespace GeneticAlgorithm
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCloseApplication = new System.Windows.Forms.Button();
            this.btnTestAlgorithm = new System.Windows.Forms.Button();
            this.txtPopulationSize = new System.Windows.Forms.TextBox();
            this.txtMergePercent = new System.Windows.Forms.TextBox();
            this.txtMutationPercent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStopValue = new System.Windows.Forms.TextBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.boxAlgorithmSettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlCalculationMethod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ddlStopCondition = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ddlSelection = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.lblCurrentBest = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mergePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mutatePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxParametersSettings = new System.Windows.Forms.GroupBox();
            this.btnAddParameter = new System.Windows.Forms.Button();
            this.panelParameters = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxA4 = new System.Windows.Forms.CheckBox();
            this.txtA1Min = new System.Windows.Forms.TextBox();
            this.checkBoxA3 = new System.Windows.Forms.CheckBox();
            this.txtA1Max = new System.Windows.Forms.TextBox();
            this.checkBoxA2 = new System.Windows.Forms.CheckBox();
            this.txtA2Min = new System.Windows.Forms.TextBox();
            this.checkBoxA1 = new System.Windows.Forms.CheckBox();
            this.txtA2Max = new System.Windows.Forms.TextBox();
            this.txtA3Min = new System.Windows.Forms.TextBox();
            this.txtA3Max = new System.Windows.Forms.TextBox();
            this.txtA4Max = new System.Windows.Forms.TextBox();
            this.txtA4Min = new System.Windows.Forms.TextBox();
            this.boxImageSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxRealTimeImage = new System.Windows.Forms.CheckBox();
            this.checkBoxRealTimeGraphic = new System.Windows.Forms.CheckBox();
            this.checkBoxGraphic = new System.Windows.Forms.CheckBox();
            this.txtImageSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boxExperimentSettings = new System.Windows.Forms.GroupBox();
            this.txtModulatorMonitorNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTestModulator = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlEvaluator = new System.Windows.Forms.ComboBox();
            this.btnEndTest = new System.Windows.Forms.Button();
            this.boxAlgorithmSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.boxParametersSettings.SuspendLayout();
            this.panelParameters.SuspendLayout();
            this.boxImageSettings.SuspendLayout();
            this.boxExperimentSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseApplication
            // 
            this.btnCloseApplication.Location = new System.Drawing.Point(1131, 484);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(139, 28);
            this.btnCloseApplication.TabIndex = 2;
            this.btnCloseApplication.Text = "Close application";
            this.btnCloseApplication.UseVisualStyleBackColor = true;
            this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
            // 
            // btnTestAlgorithm
            // 
            this.btnTestAlgorithm.Location = new System.Drawing.Point(820, 467);
            this.btnTestAlgorithm.Name = "btnTestAlgorithm";
            this.btnTestAlgorithm.Size = new System.Drawing.Size(276, 62);
            this.btnTestAlgorithm.TabIndex = 3;
            this.btnTestAlgorithm.Text = "Start algorithm";
            this.btnTestAlgorithm.UseVisualStyleBackColor = true;
            this.btnTestAlgorithm.Click += new System.EventHandler(this.btnTestAlgorithm_Click);
            // 
            // txtPopulationSize
            // 
            this.txtPopulationSize.Location = new System.Drawing.Point(149, 102);
            this.txtPopulationSize.Name = "txtPopulationSize";
            this.txtPopulationSize.Size = new System.Drawing.Size(100, 20);
            this.txtPopulationSize.TabIndex = 6;
            this.txtPopulationSize.Text = "400";
            // 
            // txtMergePercent
            // 
            this.txtMergePercent.Location = new System.Drawing.Point(149, 145);
            this.txtMergePercent.Name = "txtMergePercent";
            this.txtMergePercent.Size = new System.Drawing.Size(100, 20);
            this.txtMergePercent.TabIndex = 7;
            this.txtMergePercent.Text = "5";
            // 
            // txtMutationPercent
            // 
            this.txtMutationPercent.Location = new System.Drawing.Point(149, 191);
            this.txtMutationPercent.Name = "txtMutationPercent";
            this.txtMutationPercent.Size = new System.Drawing.Size(100, 20);
            this.txtMutationPercent.TabIndex = 8;
            this.txtMutationPercent.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Population size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Merge percent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mutation percent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Stop value";
            // 
            // txtStopValue
            // 
            this.txtStopValue.Location = new System.Drawing.Point(149, 60);
            this.txtStopValue.Name = "txtStopValue";
            this.txtStopValue.Size = new System.Drawing.Size(100, 20);
            this.txtStopValue.TabIndex = 16;
            this.txtStopValue.Text = "100";
            this.txtStopValue.WordWrap = false;
            // 
            // panelResult
            // 
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResult.Location = new System.Drawing.Point(820, 357);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(480, 73);
            this.panelResult.TabIndex = 20;
            // 
            // boxAlgorithmSettings
            // 
            this.boxAlgorithmSettings.Controls.Add(this.label4);
            this.boxAlgorithmSettings.Controls.Add(this.ddlCalculationMethod);
            this.boxAlgorithmSettings.Controls.Add(this.label9);
            this.boxAlgorithmSettings.Controls.Add(this.ddlStopCondition);
            this.boxAlgorithmSettings.Controls.Add(this.label10);
            this.boxAlgorithmSettings.Controls.Add(this.ddlSelection);
            this.boxAlgorithmSettings.Controls.Add(this.label6);
            this.boxAlgorithmSettings.Controls.Add(this.txtStopValue);
            this.boxAlgorithmSettings.Controls.Add(this.txtPopulationSize);
            this.boxAlgorithmSettings.Controls.Add(this.txtMergePercent);
            this.boxAlgorithmSettings.Controls.Add(this.txtMutationPercent);
            this.boxAlgorithmSettings.Controls.Add(this.label1);
            this.boxAlgorithmSettings.Controls.Add(this.label2);
            this.boxAlgorithmSettings.Controls.Add(this.label3);
            this.boxAlgorithmSettings.Location = new System.Drawing.Point(345, 12);
            this.boxAlgorithmSettings.Name = "boxAlgorithmSettings";
            this.boxAlgorithmSettings.Size = new System.Drawing.Size(358, 299);
            this.boxAlgorithmSettings.TabIndex = 21;
            this.boxAlgorithmSettings.TabStop = false;
            this.boxAlgorithmSettings.Text = "Algorithm settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Calculation method";
            // 
            // ddlCalculationMethod
            // 
            this.ddlCalculationMethod.FormattingEnabled = true;
            this.ddlCalculationMethod.Location = new System.Drawing.Point(149, 269);
            this.ddlCalculationMethod.Name = "ddlCalculationMethod";
            this.ddlCalculationMethod.Size = new System.Drawing.Size(201, 21);
            this.ddlCalculationMethod.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Algorithm stop condition";
            // 
            // ddlStopCondition
            // 
            this.ddlStopCondition.FormattingEnabled = true;
            this.ddlStopCondition.Location = new System.Drawing.Point(149, 25);
            this.ddlStopCondition.Name = "ddlStopCondition";
            this.ddlStopCondition.Size = new System.Drawing.Size(192, 21);
            this.ddlStopCondition.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Selection method";
            // 
            // ddlSelection
            // 
            this.ddlSelection.FormattingEnabled = true;
            this.ddlSelection.Location = new System.Drawing.Point(149, 232);
            this.ddlSelection.Name = "ddlSelection";
            this.ddlSelection.Size = new System.Drawing.Size(201, 21);
            this.ddlSelection.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Results:";
            // 
            // chartResults
            // 
            chartArea6.Name = "ChartArea1";
            this.chartResults.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartResults.Legends.Add(legend6);
            this.chartResults.Location = new System.Drawing.Point(33, 317);
            this.chartResults.Name = "chartResults";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartResults.Series.Add(series6);
            this.chartResults.Size = new System.Drawing.Size(760, 212);
            this.chartResults.TabIndex = 24;
            this.chartResults.Text = "chart1";
            // 
            // btnClearResults
            // 
            this.btnClearResults.Location = new System.Drawing.Point(33, 717);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(85, 27);
            this.btnClearResults.TabIndex = 26;
            this.btnClearResults.Text = "Clear results";
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // lblCurrentBest
            // 
            this.lblCurrentBest.AutoSize = true;
            this.lblCurrentBest.Location = new System.Drawing.Point(31, 291);
            this.lblCurrentBest.Name = "lblCurrentBest";
            this.lblCurrentBest.Size = new System.Drawing.Size(67, 13);
            this.lblCurrentBest.TabIndex = 32;
            this.lblCurrentBest.Text = "Current best:";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.AllowUserToOrderColumns = true;
            this.dataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.result,
            this.generations,
            this.selectionMethod,
            this.condition,
            this.mergePercent,
            this.mutatePercent,
            this.imageSize,
            this.populationSize,
            this.time});
            this.dataGridViewResults.Location = new System.Drawing.Point(33, 561);
            this.dataGridViewResults.MultiSelect = false;
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.Size = new System.Drawing.Size(1063, 150);
            this.dataGridViewResults.TabIndex = 34;
            this.dataGridViewResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResults_CellClick);
            this.dataGridViewResults.SelectionChanged += new System.EventHandler(this.dataGridViewResults_SelectionChanged);
            // 
            // result
            // 
            this.result.HeaderText = "Result";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // generations
            // 
            this.generations.HeaderText = "Generations";
            this.generations.Name = "generations";
            this.generations.ReadOnly = true;
            // 
            // selectionMethod
            // 
            this.selectionMethod.HeaderText = "Method";
            this.selectionMethod.Name = "selectionMethod";
            this.selectionMethod.ReadOnly = true;
            // 
            // condition
            // 
            this.condition.HeaderText = "Condition";
            this.condition.Name = "condition";
            this.condition.ReadOnly = true;
            // 
            // mergePercent
            // 
            this.mergePercent.HeaderText = "Merge %";
            this.mergePercent.Name = "mergePercent";
            this.mergePercent.ReadOnly = true;
            // 
            // mutatePercent
            // 
            this.mutatePercent.HeaderText = "Mutate %";
            this.mutatePercent.Name = "mutatePercent";
            this.mutatePercent.ReadOnly = true;
            // 
            // imageSize
            // 
            this.imageSize.HeaderText = "Img. size";
            this.imageSize.Name = "imageSize";
            this.imageSize.ReadOnly = true;
            // 
            // populationSize
            // 
            this.populationSize.HeaderText = "Pop. size";
            this.populationSize.Name = "populationSize";
            this.populationSize.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // boxParametersSettings
            // 
            this.boxParametersSettings.Controls.Add(this.btnAddParameter);
            this.boxParametersSettings.Controls.Add(this.panelParameters);
            this.boxParametersSettings.Location = new System.Drawing.Point(709, 12);
            this.boxParametersSettings.Name = "boxParametersSettings";
            this.boxParametersSettings.Size = new System.Drawing.Size(259, 299);
            this.boxParametersSettings.TabIndex = 32;
            this.boxParametersSettings.TabStop = false;
            this.boxParametersSettings.Text = "Parameters settings";
            // 
            // btnAddParameter
            // 
            this.btnAddParameter.Location = new System.Drawing.Point(6, 19);
            this.btnAddParameter.Name = "btnAddParameter";
            this.btnAddParameter.Size = new System.Drawing.Size(247, 36);
            this.btnAddParameter.TabIndex = 37;
            this.btnAddParameter.Text = "Add parameter";
            this.btnAddParameter.UseVisualStyleBackColor = true;
            this.btnAddParameter.Click += new System.EventHandler(this.btnAddParameter_Click);
            // 
            // panelParameters
            // 
            this.panelParameters.AutoScroll = true;
            this.panelParameters.Controls.Add(this.label14);
            this.panelParameters.Controls.Add(this.label15);
            this.panelParameters.Controls.Add(this.checkBoxA4);
            this.panelParameters.Controls.Add(this.txtA1Min);
            this.panelParameters.Controls.Add(this.checkBoxA3);
            this.panelParameters.Controls.Add(this.txtA1Max);
            this.panelParameters.Controls.Add(this.checkBoxA2);
            this.panelParameters.Controls.Add(this.txtA2Min);
            this.panelParameters.Controls.Add(this.checkBoxA1);
            this.panelParameters.Controls.Add(this.txtA2Max);
            this.panelParameters.Controls.Add(this.txtA3Min);
            this.panelParameters.Controls.Add(this.txtA3Max);
            this.panelParameters.Controls.Add(this.txtA4Max);
            this.panelParameters.Controls.Add(this.txtA4Min);
            this.panelParameters.Location = new System.Drawing.Point(6, 61);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(247, 170);
            this.panelParameters.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(88, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "min";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(173, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "max";
            // 
            // checkBoxA4
            // 
            this.checkBoxA4.AutoSize = true;
            this.checkBoxA4.Location = new System.Drawing.Point(21, 102);
            this.checkBoxA4.Name = "checkBoxA4";
            this.checkBoxA4.Size = new System.Drawing.Size(38, 17);
            this.checkBoxA4.TabIndex = 54;
            this.checkBoxA4.Text = "a4";
            this.checkBoxA4.UseVisualStyleBackColor = true;
            // 
            // txtA1Min
            // 
            this.txtA1Min.Location = new System.Drawing.Point(78, 34);
            this.txtA1Min.Name = "txtA1Min";
            this.txtA1Min.Size = new System.Drawing.Size(47, 20);
            this.txtA1Min.TabIndex = 41;
            this.txtA1Min.Text = "-1";
            // 
            // checkBoxA3
            // 
            this.checkBoxA3.AutoSize = true;
            this.checkBoxA3.Location = new System.Drawing.Point(21, 78);
            this.checkBoxA3.Name = "checkBoxA3";
            this.checkBoxA3.Size = new System.Drawing.Size(38, 17);
            this.checkBoxA3.TabIndex = 53;
            this.checkBoxA3.Text = "a3";
            this.checkBoxA3.UseVisualStyleBackColor = true;
            // 
            // txtA1Max
            // 
            this.txtA1Max.Location = new System.Drawing.Point(165, 34);
            this.txtA1Max.Name = "txtA1Max";
            this.txtA1Max.Size = new System.Drawing.Size(47, 20);
            this.txtA1Max.TabIndex = 42;
            this.txtA1Max.Text = "1";
            // 
            // checkBoxA2
            // 
            this.checkBoxA2.AutoSize = true;
            this.checkBoxA2.Checked = true;
            this.checkBoxA2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxA2.Location = new System.Drawing.Point(21, 56);
            this.checkBoxA2.Name = "checkBoxA2";
            this.checkBoxA2.Size = new System.Drawing.Size(38, 17);
            this.checkBoxA2.TabIndex = 52;
            this.checkBoxA2.Text = "a2";
            this.checkBoxA2.UseVisualStyleBackColor = true;
            // 
            // txtA2Min
            // 
            this.txtA2Min.Location = new System.Drawing.Point(78, 56);
            this.txtA2Min.Name = "txtA2Min";
            this.txtA2Min.Size = new System.Drawing.Size(47, 20);
            this.txtA2Min.TabIndex = 43;
            this.txtA2Min.Text = "-27";
            // 
            // checkBoxA1
            // 
            this.checkBoxA1.AutoSize = true;
            this.checkBoxA1.Checked = true;
            this.checkBoxA1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxA1.Location = new System.Drawing.Point(21, 34);
            this.checkBoxA1.Name = "checkBoxA1";
            this.checkBoxA1.Size = new System.Drawing.Size(38, 17);
            this.checkBoxA1.TabIndex = 51;
            this.checkBoxA1.Text = "a1";
            this.checkBoxA1.UseVisualStyleBackColor = true;
            // 
            // txtA2Max
            // 
            this.txtA2Max.Location = new System.Drawing.Point(165, 56);
            this.txtA2Max.Name = "txtA2Max";
            this.txtA2Max.Size = new System.Drawing.Size(47, 20);
            this.txtA2Max.TabIndex = 44;
            this.txtA2Max.Text = "27";
            // 
            // txtA3Min
            // 
            this.txtA3Min.Location = new System.Drawing.Point(78, 78);
            this.txtA3Min.Name = "txtA3Min";
            this.txtA3Min.Size = new System.Drawing.Size(47, 20);
            this.txtA3Min.TabIndex = 45;
            this.txtA3Min.Text = "-125";
            // 
            // txtA3Max
            // 
            this.txtA3Max.Location = new System.Drawing.Point(165, 78);
            this.txtA3Max.Name = "txtA3Max";
            this.txtA3Max.Size = new System.Drawing.Size(47, 20);
            this.txtA3Max.TabIndex = 46;
            this.txtA3Max.Text = "125";
            // 
            // txtA4Max
            // 
            this.txtA4Max.Location = new System.Drawing.Point(165, 100);
            this.txtA4Max.Name = "txtA4Max";
            this.txtA4Max.Size = new System.Drawing.Size(47, 20);
            this.txtA4Max.TabIndex = 48;
            this.txtA4Max.Text = "100";
            // 
            // txtA4Min
            // 
            this.txtA4Min.Location = new System.Drawing.Point(78, 100);
            this.txtA4Min.Name = "txtA4Min";
            this.txtA4Min.Size = new System.Drawing.Size(47, 20);
            this.txtA4Min.TabIndex = 47;
            this.txtA4Min.Text = "100";
            // 
            // boxImageSettings
            // 
            this.boxImageSettings.Controls.Add(this.checkBoxRealTimeImage);
            this.boxImageSettings.Controls.Add(this.checkBoxRealTimeGraphic);
            this.boxImageSettings.Controls.Add(this.checkBoxGraphic);
            this.boxImageSettings.Controls.Add(this.txtImageSize);
            this.boxImageSettings.Controls.Add(this.label5);
            this.boxImageSettings.Location = new System.Drawing.Point(974, 12);
            this.boxImageSettings.Name = "boxImageSettings";
            this.boxImageSettings.Size = new System.Drawing.Size(297, 138);
            this.boxImageSettings.TabIndex = 37;
            this.boxImageSettings.TabStop = false;
            this.boxImageSettings.Text = "Image settings";
            // 
            // checkBoxRealTimeImage
            // 
            this.checkBoxRealTimeImage.AutoSize = true;
            this.checkBoxRealTimeImage.Location = new System.Drawing.Point(31, 101);
            this.checkBoxRealTimeImage.Name = "checkBoxRealTimeImage";
            this.checkBoxRealTimeImage.Size = new System.Drawing.Size(101, 17);
            this.checkBoxRealTimeImage.TabIndex = 40;
            this.checkBoxRealTimeImage.Text = "Real time image";
            this.checkBoxRealTimeImage.UseVisualStyleBackColor = true;
            // 
            // checkBoxRealTimeGraphic
            // 
            this.checkBoxRealTimeGraphic.AutoSize = true;
            this.checkBoxRealTimeGraphic.Checked = true;
            this.checkBoxRealTimeGraphic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRealTimeGraphic.Location = new System.Drawing.Point(31, 79);
            this.checkBoxRealTimeGraphic.Name = "checkBoxRealTimeGraphic";
            this.checkBoxRealTimeGraphic.Size = new System.Drawing.Size(108, 17);
            this.checkBoxRealTimeGraphic.TabIndex = 39;
            this.checkBoxRealTimeGraphic.Text = "Real time graphic";
            this.checkBoxRealTimeGraphic.UseVisualStyleBackColor = true;
            // 
            // checkBoxGraphic
            // 
            this.checkBoxGraphic.AutoSize = true;
            this.checkBoxGraphic.Checked = true;
            this.checkBoxGraphic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGraphic.Location = new System.Drawing.Point(31, 56);
            this.checkBoxGraphic.Name = "checkBoxGraphic";
            this.checkBoxGraphic.Size = new System.Drawing.Size(225, 17);
            this.checkBoxGraphic.TabIndex = 38;
            this.checkBoxGraphic.Text = "Graphic with best individual per population";
            this.checkBoxGraphic.UseVisualStyleBackColor = true;
            // 
            // txtImageSize
            // 
            this.txtImageSize.Location = new System.Drawing.Point(168, 21);
            this.txtImageSize.Name = "txtImageSize";
            this.txtImageSize.Size = new System.Drawing.Size(100, 20);
            this.txtImageSize.TabIndex = 37;
            this.txtImageSize.Text = "120";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Image size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(817, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Result:";
            // 
            // boxExperimentSettings
            // 
            this.boxExperimentSettings.Controls.Add(this.btnEndTest);
            this.boxExperimentSettings.Controls.Add(this.txtModulatorMonitorNumber);
            this.boxExperimentSettings.Controls.Add(this.label12);
            this.boxExperimentSettings.Controls.Add(this.btnTestModulator);
            this.boxExperimentSettings.Controls.Add(this.label11);
            this.boxExperimentSettings.Controls.Add(this.ddlEvaluator);
            this.boxExperimentSettings.Location = new System.Drawing.Point(12, 12);
            this.boxExperimentSettings.Name = "boxExperimentSettings";
            this.boxExperimentSettings.Size = new System.Drawing.Size(327, 150);
            this.boxExperimentSettings.TabIndex = 39;
            this.boxExperimentSettings.TabStop = false;
            this.boxExperimentSettings.Text = "Experiment settings";
            // 
            // txtModulatorMonitorNumber
            // 
            this.txtModulatorMonitorNumber.Location = new System.Drawing.Point(125, 63);
            this.txtModulatorMonitorNumber.Name = "txtModulatorMonitorNumber";
            this.txtModulatorMonitorNumber.Size = new System.Drawing.Size(30, 20);
            this.txtModulatorMonitorNumber.TabIndex = 34;
            this.txtModulatorMonitorNumber.Text = "1";
            this.txtModulatorMonitorNumber.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 63);
            this.label12.MaximumSize = new System.Drawing.Size(100, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 26);
            this.label12.TabIndex = 37;
            this.label12.Text = "Phase modulator monitor number";
            // 
            // btnTestModulator
            // 
            this.btnTestModulator.Location = new System.Drawing.Point(161, 52);
            this.btnTestModulator.Name = "btnTestModulator";
            this.btnTestModulator.Size = new System.Drawing.Size(96, 43);
            this.btnTestModulator.TabIndex = 36;
            this.btnTestModulator.Text = "Test phase modulator";
            this.btnTestModulator.UseVisualStyleBackColor = true;
            this.btnTestModulator.Click += new System.EventHandler(this.btnTestModulator_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Measurement tool";
            // 
            // ddlEvaluator
            // 
            this.ddlEvaluator.FormattingEnabled = true;
            this.ddlEvaluator.Location = new System.Drawing.Point(125, 25);
            this.ddlEvaluator.Name = "ddlEvaluator";
            this.ddlEvaluator.Size = new System.Drawing.Size(196, 21);
            this.ddlEvaluator.TabIndex = 34;
            // 
            // btnEndTest
            // 
            this.btnEndTest.Enabled = false;
            this.btnEndTest.Location = new System.Drawing.Point(263, 52);
            this.btnEndTest.Name = "btnEndTest";
            this.btnEndTest.Size = new System.Drawing.Size(46, 43);
            this.btnEndTest.TabIndex = 38;
            this.btnEndTest.Text = "End test";
            this.btnEndTest.UseVisualStyleBackColor = true;
            this.btnEndTest.Click += new System.EventHandler(this.btnEndTest_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 755);
            this.Controls.Add(this.boxExperimentSettings);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxImageSettings);
            this.Controls.Add(this.boxParametersSettings);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.lblCurrentBest);
            this.Controls.Add(this.btnClearResults);
            this.Controls.Add(this.chartResults);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxAlgorithmSettings);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.btnTestAlgorithm);
            this.Controls.Add(this.btnCloseApplication);
            this.Name = "Home";
            this.Text = "Teo Petrov Genetic Algorithm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.boxAlgorithmSettings.ResumeLayout(false);
            this.boxAlgorithmSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.boxParametersSettings.ResumeLayout(false);
            this.panelParameters.ResumeLayout(false);
            this.panelParameters.PerformLayout();
            this.boxImageSettings.ResumeLayout(false);
            this.boxImageSettings.PerformLayout();
            this.boxExperimentSettings.ResumeLayout(false);
            this.boxExperimentSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseApplication;
        private System.Windows.Forms.Button btnTestAlgorithm;
        private System.Windows.Forms.TextBox txtPopulationSize;
        private System.Windows.Forms.TextBox txtMergePercent;
        private System.Windows.Forms.TextBox txtMutationPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStopValue;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.GroupBox boxAlgorithmSettings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ddlSelection;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddlStopCondition;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.Label lblCurrentBest;
		private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn generations;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectionMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn mergePercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn mutatePercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.GroupBox boxParametersSettings;
        private System.Windows.Forms.GroupBox boxImageSettings;
        private System.Windows.Forms.CheckBox checkBoxRealTimeImage;
        private System.Windows.Forms.CheckBox checkBoxRealTimeGraphic;
        private System.Windows.Forms.CheckBox checkBoxGraphic;
        private System.Windows.Forms.TextBox txtImageSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA4Max;
        private System.Windows.Forms.TextBox txtA4Min;
        private System.Windows.Forms.TextBox txtA3Max;
        private System.Windows.Forms.TextBox txtA3Min;
        private System.Windows.Forms.TextBox txtA2Max;
        private System.Windows.Forms.TextBox txtA2Min;
        private System.Windows.Forms.TextBox txtA1Max;
        private System.Windows.Forms.TextBox txtA1Min;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxA4;
        private System.Windows.Forms.CheckBox checkBoxA3;
        private System.Windows.Forms.CheckBox checkBoxA2;
        private System.Windows.Forms.CheckBox checkBoxA1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlCalculationMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox boxExperimentSettings;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ddlEvaluator;
        private System.Windows.Forms.Button btnTestModulator;
        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.Button btnAddParameter;
        private System.Windows.Forms.TextBox txtModulatorMonitorNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEndTest;
    }
}

