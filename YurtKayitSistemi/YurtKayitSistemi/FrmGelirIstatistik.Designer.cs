﻿namespace YurtKayitSistemi
{
    partial class FrmGelirIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirIstatistik));
            this.label1 = new System.Windows.Forms.Label();
            this.LblPara = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbAy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblAyKazanc = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasadaki Para : ";
            // 
            // LblPara
            // 
            this.LblPara.AutoSize = true;
            this.LblPara.BackColor = System.Drawing.Color.Transparent;
            this.LblPara.Location = new System.Drawing.Point(180, 77);
            this.LblPara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPara.Name = "LblPara";
            this.LblPara.Size = new System.Drawing.Size(18, 19);
            this.LblPara.TabIndex = 1;
            this.LblPara.Text = "0";
            this.LblPara.Click += new System.EventHandler(this.LblPara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ay Seçin";
            // 
            // CmbAy
            // 
            this.CmbAy.FormattingEnabled = true;
            this.CmbAy.Location = new System.Drawing.Point(133, 33);
            this.CmbAy.Name = "CmbAy";
            this.CmbAy.Size = new System.Drawing.Size(177, 27);
            this.CmbAy.TabIndex = 3;
            this.CmbAy.SelectedIndexChanged += new System.EventHandler(this.CmbAy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seçilen Ay      : ";
            // 
            // LblAyKazanc
            // 
            this.LblAyKazanc.AutoSize = true;
            this.LblAyKazanc.BackColor = System.Drawing.Color.Transparent;
            this.LblAyKazanc.Location = new System.Drawing.Point(180, 112);
            this.LblAyKazanc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAyKazanc.Name = "LblAyKazanc";
            this.LblAyKazanc.Size = new System.Drawing.Size(18, 19);
            this.LblAyKazanc.TabIndex = 4;
            this.LblAyKazanc.Text = "0";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(358, 31);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(531, 520);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // FrmGelirIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 587);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblAyKazanc);
            this.Controls.Add(this.CmbAy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblPara);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelirIstatistik";
            this.Text = "Gelir İstatistikleri";
            this.Load += new System.EventHandler(this.FrmGelirIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbAy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblAyKazanc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}