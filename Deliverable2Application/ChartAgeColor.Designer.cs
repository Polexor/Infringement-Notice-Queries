
namespace Deliverable2Application
{
    partial class ChartAgeColor
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
            this.chartAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPie = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonBar = new System.Windows.Forms.Button();
            this.chartColor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonColumn = new System.Windows.Forms.Button();
            this.buttonAgeColor = new System.Windows.Forms.Button();
            this.buttonLocation = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColor)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAge
            // 
            chartArea9.Name = "ChartArea1";
            this.chartAge.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartAge.Legends.Add(legend9);
            this.chartAge.Location = new System.Drawing.Point(86, 71);
            this.chartAge.Name = "chartAge";
            this.chartAge.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Offences";
            this.chartAge.Series.Add(series9);
            this.chartAge.Size = new System.Drawing.Size(1157, 418);
            this.chartAge.TabIndex = 0;
            this.chartAge.Text = "chart1";
            // 
            // buttonPie
            // 
            this.buttonPie.Location = new System.Drawing.Point(5, 159);
            this.buttonPie.Name = "buttonPie";
            this.buttonPie.Size = new System.Drawing.Size(75, 23);
            this.buttonPie.TabIndex = 12;
            this.buttonPie.Text = "Pie";
            this.buttonPie.UseVisualStyleBackColor = true;
            this.buttonPie.Click += new System.EventHandler(this.buttonPie_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(5, 130);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(75, 23);
            this.buttonLine.TabIndex = 11;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(5, 101);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(75, 23);
            this.buttonArea.TabIndex = 10;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonBar
            // 
            this.buttonBar.Location = new System.Drawing.Point(5, 72);
            this.buttonBar.Name = "buttonBar";
            this.buttonBar.Size = new System.Drawing.Size(75, 23);
            this.buttonBar.TabIndex = 9;
            this.buttonBar.Text = "Bar";
            this.buttonBar.UseVisualStyleBackColor = true;
            this.buttonBar.Click += new System.EventHandler(this.buttonBar_Click);
            // 
            // chartColor
            // 
            chartArea10.Name = "ChartArea1";
            this.chartColor.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartColor.Legends.Add(legend10);
            this.chartColor.Location = new System.Drawing.Point(86, 495);
            this.chartColor.Name = "chartColor";
            this.chartColor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Offences";
            this.chartColor.Series.Add(series10);
            this.chartColor.Size = new System.Drawing.Size(1157, 417);
            this.chartColor.TabIndex = 13;
            this.chartColor.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Statistics for Driver Age and Vehicle Color";
            // 
            // buttonColumn
            // 
            this.buttonColumn.Location = new System.Drawing.Point(5, 188);
            this.buttonColumn.Name = "buttonColumn";
            this.buttonColumn.Size = new System.Drawing.Size(75, 23);
            this.buttonColumn.TabIndex = 15;
            this.buttonColumn.Text = "Column";
            this.buttonColumn.UseVisualStyleBackColor = true;
            this.buttonColumn.Click += new System.EventHandler(this.buttonColumn_Click);
            // 
            // buttonAgeColor
            // 
            this.buttonAgeColor.Location = new System.Drawing.Point(589, 927);
            this.buttonAgeColor.Name = "buttonAgeColor";
            this.buttonAgeColor.Size = new System.Drawing.Size(205, 23);
            this.buttonAgeColor.TabIndex = 24;
            this.buttonAgeColor.Text = "Time Statistics";
            this.buttonAgeColor.UseVisualStyleBackColor = true;
            this.buttonAgeColor.Click += new System.EventHandler(this.buttonAgeColor_Click);
            // 
            // buttonLocation
            // 
            this.buttonLocation.Location = new System.Drawing.Point(378, 927);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(205, 23);
            this.buttonLocation.TabIndex = 23;
            this.buttonLocation.Text = "Location Statistics";
            this.buttonLocation.UseVisualStyleBackColor = true;
            this.buttonLocation.Click += new System.EventHandler(this.buttonLocation_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(800, 927);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(205, 23);
            this.buttonExit.TabIndex = 22;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.Location = new System.Drawing.Point(220, 927);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(152, 23);
            this.buttonSummary.TabIndex = 21;
            this.buttonSummary.Text = "Summary Report";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // ChartAgeColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 982);
            this.Controls.Add(this.buttonAgeColor);
            this.Controls.Add(this.buttonLocation);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartColor);
            this.Controls.Add(this.buttonPie);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonBar);
            this.Controls.Add(this.chartAge);
            this.Name = "ChartAgeColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartAgeColor";
            this.Load += new System.EventHandler(this.ChartAgeColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAge;
        private System.Windows.Forms.Button buttonPie;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonColumn;
        private System.Windows.Forms.Button buttonAgeColor;
        private System.Windows.Forms.Button buttonLocation;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSummary;
    }
}