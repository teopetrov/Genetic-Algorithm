namespace GeneticAlgorithm
{
	partial class AlgorithmForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCurrentGeneration = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblImgSize = new System.Windows.Forms.Label();
            this.lblSelMethod = new System.Windows.Forms.Label();
            this.lblMutPercent = new System.Windows.Forms.Label();
            this.lblMergePercent = new System.Windows.Forms.Label();
            this.lblPopSize = new System.Windows.Forms.Label();
            this.lblStopVal = new System.Windows.Forms.Label();
            this.lblStopCond = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkRealtimeChart = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRunAgain = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkChart = new System.Windows.Forms.CheckBox();
            this.chkRealtimeImage = new System.Windows.Forms.CheckBox();
            this.algorithmProgress = new System.Windows.Forms.ProgressBar();
            this.pnlTargetImage = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSmartMode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblCurrentGeneration);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblImgSize);
            this.groupBox1.Controls.Add(this.lblSelMethod);
            this.groupBox1.Controls.Add(this.lblMutPercent);
            this.groupBox1.Controls.Add(this.lblMergePercent);
            this.groupBox1.Controls.Add(this.lblPopSize);
            this.groupBox1.Controls.Add(this.lblStopVal);
            this.groupBox1.Controls.Add(this.lblStopCond);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm info";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(172, 226);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 18);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "label8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(65, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Current result:";
            // 
            // lblCurrentGeneration
            // 
            this.lblCurrentGeneration.AutoSize = true;
            this.lblCurrentGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentGeneration.Location = new System.Drawing.Point(172, 201);
            this.lblCurrentGeneration.Name = "lblCurrentGeneration";
            this.lblCurrentGeneration.Size = new System.Drawing.Size(52, 18);
            this.lblCurrentGeneration.TabIndex = 15;
            this.lblCurrentGeneration.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(32, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Current generation:";
            // 
            // lblImgSize
            // 
            this.lblImgSize.AutoSize = true;
            this.lblImgSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImgSize.Location = new System.Drawing.Point(172, 176);
            this.lblImgSize.Name = "lblImgSize";
            this.lblImgSize.Size = new System.Drawing.Size(52, 18);
            this.lblImgSize.TabIndex = 13;
            this.lblImgSize.Text = "label8";
            // 
            // lblSelMethod
            // 
            this.lblSelMethod.AutoSize = true;
            this.lblSelMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelMethod.Location = new System.Drawing.Point(172, 151);
            this.lblSelMethod.Name = "lblSelMethod";
            this.lblSelMethod.Size = new System.Drawing.Size(52, 18);
            this.lblSelMethod.TabIndex = 12;
            this.lblSelMethod.Text = "label9";
            // 
            // lblMutPercent
            // 
            this.lblMutPercent.AutoSize = true;
            this.lblMutPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMutPercent.Location = new System.Drawing.Point(172, 126);
            this.lblMutPercent.Name = "lblMutPercent";
            this.lblMutPercent.Size = new System.Drawing.Size(61, 18);
            this.lblMutPercent.TabIndex = 11;
            this.lblMutPercent.Text = "label10";
            // 
            // lblMergePercent
            // 
            this.lblMergePercent.AutoSize = true;
            this.lblMergePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMergePercent.Location = new System.Drawing.Point(172, 101);
            this.lblMergePercent.Name = "lblMergePercent";
            this.lblMergePercent.Size = new System.Drawing.Size(61, 18);
            this.lblMergePercent.TabIndex = 10;
            this.lblMergePercent.Text = "label11";
            // 
            // lblPopSize
            // 
            this.lblPopSize.AutoSize = true;
            this.lblPopSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPopSize.Location = new System.Drawing.Point(172, 76);
            this.lblPopSize.Name = "lblPopSize";
            this.lblPopSize.Size = new System.Drawing.Size(61, 18);
            this.lblPopSize.TabIndex = 9;
            this.lblPopSize.Text = "label12";
            // 
            // lblStopVal
            // 
            this.lblStopVal.AutoSize = true;
            this.lblStopVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStopVal.Location = new System.Drawing.Point(172, 51);
            this.lblStopVal.Name = "lblStopVal";
            this.lblStopVal.Size = new System.Drawing.Size(61, 18);
            this.lblStopVal.TabIndex = 8;
            this.lblStopVal.Text = "label13";
            // 
            // lblStopCond
            // 
            this.lblStopCond.AutoSize = true;
            this.lblStopCond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStopCond.Location = new System.Drawing.Point(172, 26);
            this.lblStopCond.Name = "lblStopCond";
            this.lblStopCond.Size = new System.Drawing.Size(61, 18);
            this.lblStopCond.TabIndex = 7;
            this.lblStopCond.Text = "label14";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(83, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Image size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(39, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Selection method:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mutation percent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Merge percent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Population size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(85, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stop value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorith stop condition:";
            // 
            // chartResults
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResults.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResults.Legends.Add(legend2);
            this.chartResults.Location = new System.Drawing.Point(21, 335);
            this.chartResults.Name = "chartResults";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResults.Series.Add(series2);
            this.chartResults.Size = new System.Drawing.Size(922, 300);
            this.chartResults.TabIndex = 1;
            this.chartResults.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlImage);
            this.groupBox2.Location = new System.Drawing.Point(688, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 144);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image";
            // 
            // pnlImage
            // 
            this.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImage.Location = new System.Drawing.Point(6, 19);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(480, 112);
            this.pnlImage.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkRealtimeChart);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnRunAgain);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.chkChart);
            this.groupBox3.Controls.Add(this.chkRealtimeImage);
            this.groupBox3.Location = new System.Drawing.Point(472, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 256);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Runtime settings";
            // 
            // chkRealtimeChart
            // 
            this.chkRealtimeChart.AutoSize = true;
            this.chkRealtimeChart.Location = new System.Drawing.Point(33, 90);
            this.chkRealtimeChart.Name = "chkRealtimeChart";
            this.chkRealtimeChart.Size = new System.Drawing.Size(119, 17);
            this.chkRealtimeChart.TabIndex = 18;
            this.chkRealtimeChart.Text = "Show realtime chart";
            this.chkRealtimeChart.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(173, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "label8";
            // 
            // btnRunAgain
            // 
            this.btnRunAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunAgain.Location = new System.Drawing.Point(18, 195);
            this.btnRunAgain.Name = "btnRunAgain";
            this.btnRunAgain.Size = new System.Drawing.Size(176, 42);
            this.btnRunAgain.TabIndex = 16;
            this.btnRunAgain.Text = "Run again";
            this.btnRunAgain.UseVisualStyleBackColor = true;
            this.btnRunAgain.Click += new System.EventHandler(this.btnRunAgain_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(18, 133);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(176, 42);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop execution";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // chkChart
            // 
            this.chkChart.AutoSize = true;
            this.chkChart.Location = new System.Drawing.Point(33, 67);
            this.chkChart.Name = "chkChart";
            this.chkChart.Size = new System.Drawing.Size(80, 17);
            this.chkChart.TabIndex = 1;
            this.chkChart.Text = "Show chart";
            this.chkChart.UseVisualStyleBackColor = true;
            this.chkChart.CheckedChanged += new System.EventHandler(this.chkChart_CheckedChanged);
            // 
            // chkRealtimeImage
            // 
            this.chkRealtimeImage.AutoSize = true;
            this.chkRealtimeImage.Location = new System.Drawing.Point(33, 44);
            this.chkRealtimeImage.Name = "chkRealtimeImage";
            this.chkRealtimeImage.Size = new System.Drawing.Size(123, 17);
            this.chkRealtimeImage.TabIndex = 0;
            this.chkRealtimeImage.Text = "Show realtime image";
            this.chkRealtimeImage.UseVisualStyleBackColor = true;
            // 
            // algorithmProgress
            // 
            this.algorithmProgress.Location = new System.Drawing.Point(21, 294);
            this.algorithmProgress.Name = "algorithmProgress";
            this.algorithmProgress.Size = new System.Drawing.Size(922, 23);
            this.algorithmProgress.TabIndex = 4;
            // 
            // pnlTargetImage
            // 
            this.pnlTargetImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTargetImage.Location = new System.Drawing.Point(694, 204);
            this.pnlTargetImage.Name = "pnlTargetImage";
            this.pnlTargetImage.Size = new System.Drawing.Size(480, 83);
            this.pnlTargetImage.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(691, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Target:";
            // 
            // lblSmartMode
            // 
            this.lblSmartMode.AutoSize = true;
            this.lblSmartMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSmartMode.Location = new System.Drawing.Point(967, 294);
            this.lblSmartMode.Name = "lblSmartMode";
            this.lblSmartMode.Size = new System.Drawing.Size(194, 18);
            this.lblSmartMode.TabIndex = 19;
            this.lblSmartMode.Text = "SMART MODE ACTIVATED";
            this.lblSmartMode.Visible = false;
            // 
            // AlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 653);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSmartMode);
            this.Controls.Add(this.pnlTargetImage);
            this.Controls.Add(this.algorithmProgress);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chartResults);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AlgorithmForm";
            this.Text = "AlgorithmForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlgorithmForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox chkChart;
		private System.Windows.Forms.CheckBox chkRealtimeImage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblImgSize;
		private System.Windows.Forms.Label lblSelMethod;
		private System.Windows.Forms.Label lblMutPercent;
		private System.Windows.Forms.Label lblMergePercent;
		private System.Windows.Forms.Label lblPopSize;
		private System.Windows.Forms.Label lblStopVal;
		private System.Windows.Forms.Label lblStopCond;
		private System.Windows.Forms.Panel pnlImage;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lblCurrentGeneration;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnRunAgain;
		private System.Windows.Forms.ProgressBar algorithmProgress;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkRealtimeChart;
        private System.Windows.Forms.Panel pnlTargetImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSmartMode;
    }
}