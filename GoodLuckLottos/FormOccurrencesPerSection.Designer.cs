namespace GoodLuckLottos
{
    partial class FormOccurrencesPerSection
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
            this.chartBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxPerid = new System.Windows.Forms.ComboBox();
            this.rdoDivBy10 = new System.Windows.Forms.RadioButton();
            this.rdoDivBy5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBar
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBar.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBar.Legends.Add(legend2);
            this.chartBar.Location = new System.Drawing.Point(12, 67);
            this.chartBar.Name = "chartBar";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBar.Series.Add(series2);
            this.chartBar.Size = new System.Drawing.Size(702, 416);
            this.chartBar.TabIndex = 0;
            this.chartBar.Text = "chart1";
            // 
            // cbxPerid
            // 
            this.cbxPerid.FormattingEnabled = true;
            this.cbxPerid.Location = new System.Drawing.Point(12, 489);
            this.cbxPerid.Name = "cbxPerid";
            this.cbxPerid.Size = new System.Drawing.Size(121, 20);
            this.cbxPerid.TabIndex = 1;
            this.cbxPerid.SelectedIndexChanged += new System.EventHandler(this.btnPeriod_Click);
            // 
            // rdoDivBy10
            // 
            this.rdoDivBy10.AutoSize = true;
            this.rdoDivBy10.Checked = true;
            this.rdoDivBy10.Location = new System.Drawing.Point(33, 29);
            this.rdoDivBy10.Name = "rdoDivBy10";
            this.rdoDivBy10.Size = new System.Drawing.Size(59, 16);
            this.rdoDivBy10.TabIndex = 3;
            this.rdoDivBy10.TabStop = true;
            this.rdoDivBy10.Text = "10번대";
            this.rdoDivBy10.UseVisualStyleBackColor = true;
            this.rdoDivBy10.CheckedChanged += new System.EventHandler(this.btnPeriod_Click);
            // 
            // rdoDivBy5
            // 
            this.rdoDivBy5.AutoSize = true;
            this.rdoDivBy5.Location = new System.Drawing.Point(113, 29);
            this.rdoDivBy5.Name = "rdoDivBy5";
            this.rdoDivBy5.Size = new System.Drawing.Size(53, 16);
            this.rdoDivBy5.TabIndex = 4;
            this.rdoDivBy5.Text = "5번대";
            this.rdoDivBy5.UseVisualStyleBackColor = true;
            this.rdoDivBy5.CheckedChanged += new System.EventHandler(this.btnPeriod_Click);
            // 
            // FormOccurrencesPerSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 535);
            this.Controls.Add(this.rdoDivBy5);
            this.Controls.Add(this.rdoDivBy10);
            this.Controls.Add(this.cbxPerid);
            this.Controls.Add(this.chartBar);
            this.Name = "FormOccurrencesPerSection";
            this.Text = "FormOccurrencesPerSection";
            this.Load += new System.EventHandler(this.FormOccurrencesPerSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataVisualization.Charting.Chart chartBar;
        private System.Windows.Forms.ComboBox cbxPerid;
        private System.Windows.Forms.RadioButton rdoDivBy10;
        private System.Windows.Forms.RadioButton rdoDivBy5;
    }
}