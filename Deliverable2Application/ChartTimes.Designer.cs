
namespace Deliverable2Application
{
    partial class ChartTimes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDays = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPie = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonBar = new System.Windows.Forms.Button();
            this.chartHours = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonColumn = new System.Windows.Forms.Button();
            this.buttonAgeColor = new System.Windows.Forms.Button();
            this.buttonLocation = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHours)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDays
            // 
            chartArea9.Name = "ChartArea1";
            this.chartDays.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartDays.Legends.Add(legend9);
            this.chartDays.Location = new System.Drawing.Point(107, 76);
            this.chartDays.Name = "chartDays";
            this.chartDays.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Offences";
            series9.YValuesPerPoint = 4;
            this.chartDays.Series.Add(series9);
            this.chartDays.Size = new System.Drawing.Size(1157, 418);
            this.chartDays.TabIndex = 0;
            this.chartDays.Text = "chart1";
            // 
            // buttonPie
            // 
            this.buttonPie.Location = new System.Drawing.Point(14, 163);
            this.buttonPie.Name = "buttonPie";
            this.buttonPie.Size = new System.Drawing.Size(75, 23);
            this.buttonPie.TabIndex = 8;
            this.buttonPie.Text = "Pie";
            this.buttonPie.UseVisualStyleBackColor = true;
            this.buttonPie.Click += new System.EventHandler(this.buttonPie_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(14, 134);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(75, 23);
            this.buttonLine.TabIndex = 7;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(14, 105);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(75, 23);
            this.buttonArea.TabIndex = 6;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonBar
            // 
            this.buttonBar.Location = new System.Drawing.Point(14, 76);
            this.buttonBar.Name = "buttonBar";
            this.buttonBar.Size = new System.Drawing.Size(75, 23);
            this.buttonBar.TabIndex = 5;
            this.buttonBar.Text = "Bar";
            this.buttonBar.UseVisualStyleBackColor = true;
            this.buttonBar.Click += new System.EventHandler(this.buttonBar_Click);
            // 
            // chartHours
            // 
            chartArea10.Name = "ChartArea1";
            this.chartHours.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartHours.Legends.Add(legend10);
            this.chartHours.Location = new System.Drawing.Point(107, 531);
            this.chartHours.Name = "chartHours";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series10.Legend = "Legend1";
            series10.Name = "Offences";
            this.chartHours.Series.Add(series10);
            this.chartHours.Size = new System.Drawing.Size(1157, 418);
            this.chartHours.TabIndex = 9;
            this.chartHours.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Statistics for Time of Day and Day of Week";
            // 
            // buttonSummary
            // 
            this.buttonSummary.Location = new System.Drawing.Point(246, 976);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(152, 23);
            this.buttonSummary.TabIndex = 11;
            this.buttonSummary.Text = "Summary Report";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // buttonColumn
            // 
            this.buttonColumn.Location = new System.Drawing.Point(14, 192);
            this.buttonColumn.Name = "buttonColumn";
            this.buttonColumn.Size = new System.Drawing.Size(75, 23);
            this.buttonColumn.TabIndex = 16;
            this.buttonColumn.Text = "Column";
            this.buttonColumn.UseVisualStyleBackColor = true;
            this.buttonColumn.Click += new System.EventHandler(this.buttonColumn_Click);
            // 
            // buttonAgeColor
            // 
            this.buttonAgeColor.Location = new System.Drawing.Point(615, 976);
            this.buttonAgeColor.Name = "buttonAgeColor";
            this.buttonAgeColor.Size = new System.Drawing.Size(205, 23);
            this.buttonAgeColor.TabIndex = 20;
            this.buttonAgeColor.Text = "Vehicle Statistics";
            this.buttonAgeColor.UseVisualStyleBackColor = true;
            this.buttonAgeColor.Click += new System.EventHandler(this.buttonAgeColor_Click);
            // 
            // buttonLocation
            // 
            this.buttonLocation.Location = new System.Drawing.Point(404, 976);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(205, 23);
            this.buttonLocation.TabIndex = 19;
            this.buttonLocation.Text = "Location Statistics";
            this.buttonLocation.UseVisualStyleBackColor = true;
            this.buttonLocation.Click += new System.EventHandler(this.buttonTimeStats_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(826, 976);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(205, 23);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ChartTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 1062);
            this.Controls.Add(this.buttonAgeColor);
            this.Controls.Add(this.buttonLocation);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonColumn);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartHours);
            this.Controls.Add(this.buttonPie);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonBar);
            this.Controls.Add(this.chartDays);
            this.Name = "ChartTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartTimes";
            this.Load += new System.EventHandler(this.ChartTimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDays;
        private System.Windows.Forms.Button buttonPie;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonColumn;
        private System.Windows.Forms.Button buttonAgeColor;
        private System.Windows.Forms.Button buttonLocation;
        private System.Windows.Forms.Button buttonExit;
    }
}