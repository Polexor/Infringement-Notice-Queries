
namespace Deliverable2Application
{
    partial class ChartStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonBar = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonPie = new System.Windows.Forms.Button();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGraphSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLightCon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonTimeStats = new System.Windows.Forms.Button();
            this.buttonColumn = new System.Windows.Forms.Button();
            this.buttonAgeColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLightCon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBar
            // 
            this.buttonBar.Location = new System.Drawing.Point(9, 70);
            this.buttonBar.Name = "buttonBar";
            this.buttonBar.Size = new System.Drawing.Size(75, 23);
            this.buttonBar.TabIndex = 1;
            this.buttonBar.Text = "Bar";
            this.buttonBar.UseVisualStyleBackColor = true;
            this.buttonBar.Click += new System.EventHandler(this.buttonBar_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(9, 99);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(75, 23);
            this.buttonArea.TabIndex = 2;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(9, 128);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(75, 23);
            this.buttonLine.TabIndex = 3;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonPie
            // 
            this.buttonPie.Location = new System.Drawing.Point(9, 157);
            this.buttonPie.Name = "buttonPie";
            this.buttonPie.Size = new System.Drawing.Size(75, 23);
            this.buttonPie.TabIndex = 4;
            this.buttonPie.Text = "Pie";
            this.buttonPie.UseVisualStyleBackColor = true;
            this.buttonPie.Click += new System.EventHandler(this.buttonPie_Click);
            // 
            // chartGraph
            // 
            chartArea7.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartGraph.Legends.Add(legend7);
            this.chartGraph.Location = new System.Drawing.Point(90, 70);
            this.chartGraph.Name = "chartGraph";
            this.chartGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Offences";
            this.chartGraph.Series.Add(series7);
            this.chartGraph.Size = new System.Drawing.Size(576, 360);
            this.chartGraph.TabIndex = 5;
            this.chartGraph.Text = "chart";
            // 
            // chartGraphSpeed
            // 
            chartArea8.Name = "ChartArea1";
            this.chartGraphSpeed.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartGraphSpeed.Legends.Add(legend8);
            this.chartGraphSpeed.Location = new System.Drawing.Point(703, 70);
            this.chartGraphSpeed.Name = "chartGraphSpeed";
            this.chartGraphSpeed.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Offences";
            this.chartGraphSpeed.Series.Add(series8);
            this.chartGraphSpeed.Size = new System.Drawing.Size(576, 360);
            this.chartGraphSpeed.TabIndex = 6;
            this.chartGraphSpeed.Text = "chart";
            // 
            // chartLightCon
            // 
            chartArea9.Name = "ChartArea1";
            this.chartLightCon.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartLightCon.Legends.Add(legend9);
            this.chartLightCon.Location = new System.Drawing.Point(1301, 70);
            this.chartLightCon.Name = "chartLightCon";
            this.chartLightCon.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Offences";
            this.chartLightCon.Series.Add(series9);
            this.chartLightCon.Size = new System.Drawing.Size(576, 360);
            this.chartLightCon.TabIndex = 7;
            this.chartLightCon.Text = "chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Statistics For Lanes, Speed Limit and Light Conditions";
            // 
            // buttonSummary
            // 
            this.buttonSummary.Location = new System.Drawing.Point(581, 451);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(205, 23);
            this.buttonSummary.TabIndex = 10;
            this.buttonSummary.Text = "Summary Report";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1214, 451);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(205, 23);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonTimeStats
            // 
            this.buttonTimeStats.Location = new System.Drawing.Point(792, 451);
            this.buttonTimeStats.Name = "buttonTimeStats";
            this.buttonTimeStats.Size = new System.Drawing.Size(205, 23);
            this.buttonTimeStats.TabIndex = 13;
            this.buttonTimeStats.Text = "Time Statistics";
            this.buttonTimeStats.UseVisualStyleBackColor = true;
            this.buttonTimeStats.Click += new System.EventHandler(this.buttonTimeStats_Click);
            // 
            // buttonColumn
            // 
            this.buttonColumn.Location = new System.Drawing.Point(9, 186);
            this.buttonColumn.Name = "buttonColumn";
            this.buttonColumn.Size = new System.Drawing.Size(75, 23);
            this.buttonColumn.TabIndex = 16;
            this.buttonColumn.Text = "Column";
            this.buttonColumn.UseVisualStyleBackColor = true;
            this.buttonColumn.Click += new System.EventHandler(this.buttonColumn_Click);
            // 
            // buttonAgeColor
            // 
            this.buttonAgeColor.Location = new System.Drawing.Point(1003, 451);
            this.buttonAgeColor.Name = "buttonAgeColor";
            this.buttonAgeColor.Size = new System.Drawing.Size(205, 23);
            this.buttonAgeColor.TabIndex = 17;
            this.buttonAgeColor.Text = "Vehicle Statistics";
            this.buttonAgeColor.UseVisualStyleBackColor = true;
            this.buttonAgeColor.Click += new System.EventHandler(this.buttonAgeColor_Click);
            // 
            // ChartStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 496);
            this.Controls.Add(this.buttonAgeColor);
            this.Controls.Add(this.buttonColumn);
            this.Controls.Add(this.buttonTimeStats);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartLightCon);
            this.Controls.Add(this.chartGraphSpeed);
            this.Controls.Add(this.chartGraph);
            this.Controls.Add(this.buttonPie);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonBar);
            this.Name = "ChartStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartStats";
            this.Load += new System.EventHandler(this.ChartStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLightCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBar;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphSpeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLightCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonTimeStats;
        private System.Windows.Forms.Button buttonColumn;
        private System.Windows.Forms.Button buttonAgeColor;
    }
}