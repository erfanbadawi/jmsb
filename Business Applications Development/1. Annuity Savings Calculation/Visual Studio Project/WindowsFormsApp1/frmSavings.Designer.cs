namespace WindowsFormsApp1
{
    partial class frmSavings
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.txtMonthlySavings = new System.Windows.Forms.TextBox();
            this.txtAnnualInterestPercentage = new System.Windows.Forms.TextBox();
            this.txtMonthNumber = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Savings:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual Interest (%):";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Months:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(32, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMonth.Location = new System.Drawing.Point(175, 311);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(100, 39);
            this.btnNextMonth.TabIndex = 5;
            this.btnNextMonth.Text = "&Next Month";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // txtMonthlySavings
            // 
            this.txtMonthlySavings.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlySavings.Location = new System.Drawing.Point(191, 43);
            this.txtMonthlySavings.Name = "txtMonthlySavings";
            this.txtMonthlySavings.Size = new System.Drawing.Size(84, 24);
            this.txtMonthlySavings.TabIndex = 6;
            // 
            // txtAnnualInterestPercentage
            // 
            this.txtAnnualInterestPercentage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnualInterestPercentage.Location = new System.Drawing.Point(191, 101);
            this.txtAnnualInterestPercentage.Name = "txtAnnualInterestPercentage";
            this.txtAnnualInterestPercentage.Size = new System.Drawing.Size(84, 24);
            this.txtAnnualInterestPercentage.TabIndex = 7;
            // 
            // txtMonthNumber
            // 
            this.txtMonthNumber.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthNumber.Location = new System.Drawing.Point(191, 178);
            this.txtMonthNumber.Name = "txtMonthNumber";
            this.txtMonthNumber.ReadOnly = true;
            this.txtMonthNumber.Size = new System.Drawing.Size(84, 25);
            this.txtMonthNumber.TabIndex = 8;
            this.txtMonthNumber.Text = "0";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(191, 230);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(84, 25);
            this.txtBalance.TabIndex = 9;
            this.txtBalance.Text = "$0.00";
            // 
            // frmSavings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 407);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtMonthNumber);
            this.Controls.Add(this.txtAnnualInterestPercentage);
            this.Controls.Add(this.txtMonthlySavings);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSavings";
            this.Text = "Savings Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.TextBox txtMonthlySavings;
        private System.Windows.Forms.TextBox txtAnnualInterestPercentage;
        private System.Windows.Forms.TextBox txtMonthNumber;
        private System.Windows.Forms.TextBox txtBalance;
    }
}

