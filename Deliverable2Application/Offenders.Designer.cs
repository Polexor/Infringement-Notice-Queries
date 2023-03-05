
namespace Deliverable2Application
{
    partial class Offenders
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.offenderListBox = new System.Windows.Forms.ListBox();
            this.buttonAddUpOffence = new System.Windows.Forms.Button();
            this.buttonInfringement = new System.Windows.Forms.Button();
            this.buttonFilterInfringement = new System.Windows.Forms.Button();
            this.buttonUnpaidInfringements = new System.Windows.Forms.Button();
            this.buttonOverDueInfringemnts = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Browse Offences";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(159, 429);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(159, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "All Offences";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(654, 459);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(159, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // offenderListBox
            // 
            this.offenderListBox.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offenderListBox.FormattingEnabled = true;
            this.offenderListBox.ItemHeight = 17;
            this.offenderListBox.Location = new System.Drawing.Point(6, 63);
            this.offenderListBox.Name = "offenderListBox";
            this.offenderListBox.Size = new System.Drawing.Size(985, 361);
            this.offenderListBox.TabIndex = 9;
            // 
            // buttonAddUpOffence
            // 
            this.buttonAddUpOffence.Location = new System.Drawing.Point(159, 459);
            this.buttonAddUpOffence.Name = "buttonAddUpOffence";
            this.buttonAddUpOffence.Size = new System.Drawing.Size(159, 23);
            this.buttonAddUpOffence.TabIndex = 10;
            this.buttonAddUpOffence.Text = "Add Update Offences";
            this.buttonAddUpOffence.UseVisualStyleBackColor = true;
            this.buttonAddUpOffence.Click += new System.EventHandler(this.buttonAddUpOffence_Click);
            // 
            // buttonInfringement
            // 
            this.buttonInfringement.Location = new System.Drawing.Point(489, 459);
            this.buttonInfringement.Name = "buttonInfringement";
            this.buttonInfringement.Size = new System.Drawing.Size(159, 23);
            this.buttonInfringement.TabIndex = 11;
            this.buttonInfringement.Text = "Infringement Notices";
            this.buttonInfringement.UseVisualStyleBackColor = true;
            this.buttonInfringement.Click += new System.EventHandler(this.buttonInfringement_Click);
            // 
            // buttonFilterInfringement
            // 
            this.buttonFilterInfringement.Location = new System.Drawing.Point(324, 430);
            this.buttonFilterInfringement.Name = "buttonFilterInfringement";
            this.buttonFilterInfringement.Size = new System.Drawing.Size(159, 23);
            this.buttonFilterInfringement.TabIndex = 12;
            this.buttonFilterInfringement.Text = "No Infringement Notices";
            this.buttonFilterInfringement.UseVisualStyleBackColor = true;
            this.buttonFilterInfringement.Click += new System.EventHandler(this.buttonFilterInfringement_Click);
            // 
            // buttonUnpaidInfringements
            // 
            this.buttonUnpaidInfringements.Location = new System.Drawing.Point(489, 430);
            this.buttonUnpaidInfringements.Name = "buttonUnpaidInfringements";
            this.buttonUnpaidInfringements.Size = new System.Drawing.Size(159, 23);
            this.buttonUnpaidInfringements.TabIndex = 13;
            this.buttonUnpaidInfringements.Text = "Unpaid Infringements";
            this.buttonUnpaidInfringements.UseVisualStyleBackColor = true;
            this.buttonUnpaidInfringements.Click += new System.EventHandler(this.buttonUnpaidInfringements_Click);
            // 
            // buttonOverDueInfringemnts
            // 
            this.buttonOverDueInfringemnts.Location = new System.Drawing.Point(654, 430);
            this.buttonOverDueInfringemnts.Name = "buttonOverDueInfringemnts";
            this.buttonOverDueInfringemnts.Size = new System.Drawing.Size(159, 23);
            this.buttonOverDueInfringemnts.TabIndex = 14;
            this.buttonOverDueInfringemnts.Text = "Overdue Infringements";
            this.buttonOverDueInfringemnts.UseVisualStyleBackColor = true;
            this.buttonOverDueInfringemnts.Click += new System.EventHandler(this.buttonOverDueInfringemnts_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.Location = new System.Drawing.Point(324, 459);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(159, 23);
            this.buttonSummary.TabIndex = 15;
            this.buttonSummary.Text = "Summary Report";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // Offenders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 493);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonOverDueInfringemnts);
            this.Controls.Add(this.buttonUnpaidInfringements);
            this.Controls.Add(this.buttonFilterInfringement);
            this.Controls.Add(this.buttonInfringement);
            this.Controls.Add(this.buttonAddUpOffence);
            this.Controls.Add(this.offenderListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Name = "Offenders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox offenderListBox;
        private System.Windows.Forms.Button buttonAddUpOffence;
        private System.Windows.Forms.Button buttonInfringement;
        private System.Windows.Forms.Button buttonFilterInfringement;
        private System.Windows.Forms.Button buttonUnpaidInfringements;
        private System.Windows.Forms.Button buttonOverDueInfringemnts;
        private System.Windows.Forms.Button buttonSummary;
    }
}

