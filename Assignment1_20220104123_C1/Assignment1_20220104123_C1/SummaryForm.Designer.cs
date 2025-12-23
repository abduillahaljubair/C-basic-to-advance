using System;

namespace Assignment1_20220104123_C1
{
    partial class SummaryForm
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

        private void InitializeComponent()
        {
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lstGrades = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(247, 76);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(183, 23);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.Text = "Average:";
            // 
            // lblHigh
            // 
            this.lblHigh.Location = new System.Drawing.Point(247, 108);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(177, 32);
            this.lblHigh.TabIndex = 1;
            this.lblHigh.Text = "Highest:";
            // 
            // lblLow
            // 
            this.lblLow.Location = new System.Drawing.Point(247, 140);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(177, 25);
            this.lblLow.TabIndex = 2;
            this.lblLow.Text = "Lowest:";
            // 
            // lstGrades
            // 
            this.lstGrades.FormattingEnabled = true;
            this.lstGrades.ItemHeight = 16;
            this.lstGrades.Location = new System.Drawing.Point(250, 181);
            this.lstGrades.Name = "lstGrades";
            this.lstGrades.Size = new System.Drawing.Size(282, 84);
            this.lstGrades.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(250, 280);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);  // ✅ event handler যোগ
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstGrades);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblAverage);
            this.Name = "SummaryForm";
            this.Text = "Summary Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.ListBox lstGrades;
        private System.Windows.Forms.Button btnBack;
    }
}
