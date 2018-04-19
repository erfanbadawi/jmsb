namespace WindowsFormsApp2
{
    partial class ProjectCalculator
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
            this.lblInitialInvestment = new System.Windows.Forms.Label();
            this.lblYearlyRevenue = new System.Windows.Forms.Label();
            this.lblYearlyExpenses = new System.Windows.Forms.Label();
            this.txtInitialInvestment = new System.Windows.Forms.TextBox();
            this.txtYearlyRevenue = new System.Windows.Forms.TextBox();
            this.txtYearlyExpenses = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBreakEvenYear = new System.Windows.Forms.Label();
            this.txtBreakEvenYear = new System.Windows.Forms.TextBox();
            this.btnDoubleBE = new System.Windows.Forms.Button();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lstProfit = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInitialInvestment
            // 
            this.lblInitialInvestment.AutoSize = true;
            this.lblInitialInvestment.Location = new System.Drawing.Point(24, 31);
            this.lblInitialInvestment.Name = "lblInitialInvestment";
            this.lblInitialInvestment.Size = new System.Drawing.Size(128, 19);
            this.lblInitialInvestment.TabIndex = 0;
            this.lblInitialInvestment.Text = "Initial Investment";
            // 
            // lblYearlyRevenue
            // 
            this.lblYearlyRevenue.AutoSize = true;
            this.lblYearlyRevenue.Location = new System.Drawing.Point(24, 82);
            this.lblYearlyRevenue.Name = "lblYearlyRevenue";
            this.lblYearlyRevenue.Size = new System.Drawing.Size(113, 19);
            this.lblYearlyRevenue.TabIndex = 1;
            this.lblYearlyRevenue.Text = "Yearly Revenue";
            // 
            // lblYearlyExpenses
            // 
            this.lblYearlyExpenses.AutoSize = true;
            this.lblYearlyExpenses.Location = new System.Drawing.Point(24, 130);
            this.lblYearlyExpenses.Name = "lblYearlyExpenses";
            this.lblYearlyExpenses.Size = new System.Drawing.Size(115, 19);
            this.lblYearlyExpenses.TabIndex = 2;
            this.lblYearlyExpenses.Text = "Yearly Expenses";
            // 
            // txtInitialInvestment
            // 
            this.txtInitialInvestment.Location = new System.Drawing.Point(167, 28);
            this.txtInitialInvestment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInitialInvestment.Name = "txtInitialInvestment";
            this.txtInitialInvestment.Size = new System.Drawing.Size(81, 27);
            this.txtInitialInvestment.TabIndex = 3;
            // 
            // txtYearlyRevenue
            // 
            this.txtYearlyRevenue.Location = new System.Drawing.Point(167, 79);
            this.txtYearlyRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYearlyRevenue.Name = "txtYearlyRevenue";
            this.txtYearlyRevenue.Size = new System.Drawing.Size(81, 27);
            this.txtYearlyRevenue.TabIndex = 4;
            // 
            // txtYearlyExpenses
            // 
            this.txtYearlyExpenses.Location = new System.Drawing.Point(167, 127);
            this.txtYearlyExpenses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYearlyExpenses.Name = "txtYearlyExpenses";
            this.txtYearlyExpenses.Size = new System.Drawing.Size(81, 27);
            this.txtYearlyExpenses.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(28, 174);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(109, 29);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBreakEvenYear
            // 
            this.lblBreakEvenYear.AutoSize = true;
            this.lblBreakEvenYear.Location = new System.Drawing.Point(24, 226);
            this.lblBreakEvenYear.Name = "lblBreakEvenYear";
            this.lblBreakEvenYear.Size = new System.Drawing.Size(118, 19);
            this.lblBreakEvenYear.TabIndex = 7;
            this.lblBreakEvenYear.Text = "Break Even Year";
            // 
            // txtBreakEvenYear
            // 
            this.txtBreakEvenYear.Location = new System.Drawing.Point(167, 223);
            this.txtBreakEvenYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBreakEvenYear.Name = "txtBreakEvenYear";
            this.txtBreakEvenYear.Size = new System.Drawing.Size(81, 27);
            this.txtBreakEvenYear.TabIndex = 8;
            // 
            // btnDoubleBE
            // 
            this.btnDoubleBE.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoubleBE.Location = new System.Drawing.Point(24, 280);
            this.btnDoubleBE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoubleBE.Name = "btnDoubleBE";
            this.btnDoubleBE.Size = new System.Drawing.Size(113, 46);
            this.btnDoubleBE.TabIndex = 9;
            this.btnDoubleBE.Text = "Calculate for double BE years";
            this.btnDoubleBE.UseVisualStyleBackColor = true;
            this.btnDoubleBE.Click += new System.EventHandler(this.btnDoubleBE_Click);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProfit.Font = new System.Drawing.Font("Calibri Light", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(158, 279);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(108, 16);
            this.lblProfit.TabIndex = 10;
            this.lblProfit.Text = "Cumulative Profit";
            // 
            // lstProfit
            // 
            this.lstProfit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProfit.FormattingEnabled = true;
            this.lstProfit.ItemHeight = 19;
            this.lstProfit.Location = new System.Drawing.Point(158, 299);
            this.lstProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstProfit.Name = "lstProfit";
            this.lstProfit.Size = new System.Drawing.Size(108, 118);
            this.lstProfit.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(28, 368);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 33);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ProjectCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 439);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstProfit);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.btnDoubleBE);
            this.Controls.Add(this.txtBreakEvenYear);
            this.Controls.Add(this.lblBreakEvenYear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtYearlyExpenses);
            this.Controls.Add(this.txtYearlyRevenue);
            this.Controls.Add(this.txtInitialInvestment);
            this.Controls.Add(this.lblYearlyExpenses);
            this.Controls.Add(this.lblYearlyRevenue);
            this.Controls.Add(this.lblInitialInvestment);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProjectCalculator";
            this.Text = "Project Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInitialInvestment;
        private System.Windows.Forms.Label lblYearlyRevenue;
        private System.Windows.Forms.Label lblYearlyExpenses;
        private System.Windows.Forms.TextBox txtInitialInvestment;
        private System.Windows.Forms.TextBox txtYearlyRevenue;
        private System.Windows.Forms.TextBox txtYearlyExpenses;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBreakEvenYear;
        private System.Windows.Forms.TextBox txtBreakEvenYear;
        private System.Windows.Forms.Button btnDoubleBE;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.ListBox lstProfit;
        private System.Windows.Forms.Button btnExit;
    }
}

