﻿namespace GeneticAlgorithm
{
    partial class FullScreenImage
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
            this.pаnеlImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pаnеlImage
            // 
            this.pаnеlImage.BackColor = System.Drawing.Color.White;
            this.pаnеlImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pаnеlImage.Location = new System.Drawing.Point(27, 30);
            this.pаnеlImage.Name = "pаnеlImage";
            this.pаnеlImage.Size = new System.Drawing.Size(480, 100);
            this.pаnеlImage.TabIndex = 0;
            // 
            // FullScreenImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pаnеlImage);
            this.Name = "FullScreenImage";
            this.Text = "FullScreenImage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pаnеlImage;
    }
}