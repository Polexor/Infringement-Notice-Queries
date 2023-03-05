
namespace Deliverable2Application
{
    partial class SummaryReport
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
            this.listBoxSummaryReport = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowseOffences = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonInfNotice = new System.Windows.Forms.Button();
            this.buttonAddUpOff = new System.Windows.Forms.Button();
            this.buttonChartStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSummaryReport
            // 
            this.listBoxSummaryReport.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSummaryReport.FormattingEnabled = true;
            this.listBoxSummaryReport.ItemHeight = 17;
            this.listBoxSummaryReport.Location = new System.Drawing.Point(12, 48);
            this.listBoxSummaryReport.Name = "listBoxSummaryReport";
            this.listBoxSummaryReport.Size = new System.Drawing.Size(360, 344);
            this.listBoxSummaryReport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Summary Report";
            // 
            // buttonBrowseOffences
            // 
            this.buttonBrowseOffences.Location = new System.Drawing.Point(12, 398);
            this.buttonBrowseOffences.Name = "buttonBrowseOffences";
            this.buttonBrowseOffences.Size = new System.Drawing.Size(106, 23);
            this.buttonBrowseOffences.TabIndex = 2;
            this.buttonBrowseOffences.Text = "Browse Offences";
            this.buttonBrowseOffences.UseVisualStyleBackColor = true;
            this.buttonBrowseOffences.Click += new System.EventHandler(this.buttonBrowseOffences_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(124, 427);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(115, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonInfNotice
            // 
            this.buttonInfNotice.Location = new System.Drawing.Point(124, 398);
            this.buttonInfNotice.Name = "buttonInfNotice";
            this.buttonInfNotice.Size = new System.Drawing.Size(115, 23);
            this.buttonInfNotice.TabIndex = 6;
            this.buttonInfNotice.Text = "Infringement Notices";
            this.buttonInfNotice.UseVisualStyleBackColor = true;
            this.buttonInfNotice.Click += new System.EventHandler(this.buttonInfNotice_Click);
            // 
            // buttonAddUpOff
            // 
            this.buttonAddUpOff.Location = new System.Drawing.Point(248, 398);
            this.buttonAddUpOff.Name = "buttonAddUpOff";
            this.buttonAddUpOff.Size = new System.Drawing.Size(124, 23);
            this.buttonAddUpOff.TabIndex = 7;
            this.buttonAddUpOff.Text = "Add Update Offences";
            this.buttonAddUpOff.UseVisualStyleBackColor = true;
            this.buttonAddUpOff.Click += new System.EventHandler(this.buttonAddUpOff_Click);
            // 
            // buttonChartStats
            // 
            this.buttonChartStats.Location = new System.Drawing.Point(12, 427);
            this.buttonChartStats.Name = "buttonChartStats";
            this.buttonChartStats.Size = new System.Drawing.Size(106, 23);
            this.buttonChartStats.TabIndex = 8;
            this.buttonChartStats.Text = "Statistics";
            this.buttonChartStats.UseVisualStyleBackColor = true;
            this.buttonChartStats.Click += new System.EventHandler(this.buttonChartStats_Click);
            // 
            // SummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 458);
            this.Controls.Add(this.buttonChartStats);
            this.Controls.Add(this.buttonAddUpOff);
            this.Controls.Add(this.buttonInfNotice);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBrowseOffences);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSummaryReport);
            this.Name = "SummaryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SummaryReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSummaryReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowseOffences;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInfNotice;
        private System.Windows.Forms.Button buttonAddUpOff;
        private System.Windows.Forms.Button buttonChartStats;
    }
}