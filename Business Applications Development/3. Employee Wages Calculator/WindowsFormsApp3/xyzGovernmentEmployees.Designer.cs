namespace WindowsFormsApp3
{
    partial class xyzGovernmentEmployees
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
            this.radCategoryA = new System.Windows.Forms.RadioButton();
            this.radCategoryB = new System.Windows.Forms.RadioButton();
            this.lblService = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPensionSaving = new System.Windows.Forms.Label();
            this.radSavingsNone = new System.Windows.Forms.RadioButton();
            this.radSavingsMedium = new System.Windows.Forms.RadioButton();
            this.radSavingsHighest = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblGrossSalary = new System.Windows.Forms.Label();
            this.txtGrossSalary = new System.Windows.Forms.TextBox();
            this.lblPensionDeduct = new System.Windows.Forms.Label();
            this.txtPensionDeduct = new System.Windows.Forms.TextBox();
            this.lblTaxDeduct = new System.Windows.Forms.Label();
            this.txtTaxDeduct = new System.Windows.Forms.TextBox();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtYearsService = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radCategoryA
            // 
            this.radCategoryA.AutoSize = true;
            this.radCategoryA.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCategoryA.Location = new System.Drawing.Point(3, 3);
            this.radCategoryA.Name = "radCategoryA";
            this.radCategoryA.Size = new System.Drawing.Size(93, 22);
            this.radCategoryA.TabIndex = 0;
            this.radCategoryA.TabStop = true;
            this.radCategoryA.Text = "Category A";
            this.radCategoryA.UseVisualStyleBackColor = true;
            // 
            // radCategoryB
            // 
            this.radCategoryB.AutoSize = true;
            this.radCategoryB.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCategoryB.Location = new System.Drawing.Point(3, 31);
            this.radCategoryB.Name = "radCategoryB";
            this.radCategoryB.Size = new System.Drawing.Size(92, 22);
            this.radCategoryB.TabIndex = 1;
            this.radCategoryB.TabStop = true;
            this.radCategoryB.Text = "Category B";
            this.radCategoryB.UseVisualStyleBackColor = true;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblService.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(17, 161);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(96, 19);
            this.lblService.TabIndex = 3;
            this.lblService.Text = "Years of service";
            this.lblService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPensionSaving
            // 
            this.lblPensionSaving.AutoSize = true;
            this.lblPensionSaving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPensionSaving.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionSaving.Location = new System.Drawing.Point(160, 29);
            this.lblPensionSaving.Name = "lblPensionSaving";
            this.lblPensionSaving.Size = new System.Drawing.Size(118, 19);
            this.lblPensionSaving.TabIndex = 5;
            this.lblPensionSaving.Text = "Pension saving plan";
            this.lblPensionSaving.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radSavingsNone
            // 
            this.radSavingsNone.AutoSize = true;
            this.radSavingsNone.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSavingsNone.Location = new System.Drawing.Point(7, 3);
            this.radSavingsNone.Name = "radSavingsNone";
            this.radSavingsNone.Size = new System.Drawing.Size(47, 22);
            this.radSavingsNone.TabIndex = 6;
            this.radSavingsNone.TabStop = true;
            this.radSavingsNone.Text = "0 %";
            this.radSavingsNone.UseVisualStyleBackColor = true;
            // 
            // radSavingsMedium
            // 
            this.radSavingsMedium.AutoSize = true;
            this.radSavingsMedium.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSavingsMedium.Location = new System.Drawing.Point(7, 31);
            this.radSavingsMedium.Name = "radSavingsMedium";
            this.radSavingsMedium.Size = new System.Drawing.Size(47, 22);
            this.radSavingsMedium.TabIndex = 7;
            this.radSavingsMedium.TabStop = true;
            this.radSavingsMedium.Text = "3 %";
            this.radSavingsMedium.UseVisualStyleBackColor = true;
            // 
            // radSavingsHighest
            // 
            this.radSavingsHighest.AutoSize = true;
            this.radSavingsHighest.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSavingsHighest.Location = new System.Drawing.Point(7, 61);
            this.radSavingsHighest.Name = "radSavingsHighest";
            this.radSavingsHighest.Size = new System.Drawing.Size(47, 22);
            this.radSavingsHighest.TabIndex = 8;
            this.radSavingsHighest.TabStop = true;
            this.radSavingsHighest.Text = "5 %";
            this.radSavingsHighest.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalculate.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(160, 192);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(118, 25);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = " CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblGrossSalary
            // 
            this.lblGrossSalary.AutoSize = true;
            this.lblGrossSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossSalary.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossSalary.Location = new System.Drawing.Point(17, 254);
            this.lblGrossSalary.Name = "lblGrossSalary";
            this.lblGrossSalary.Size = new System.Drawing.Size(78, 19);
            this.lblGrossSalary.TabIndex = 10;
            this.lblGrossSalary.Text = "Gross Salary";
            // 
            // txtGrossSalary
            // 
            this.txtGrossSalary.Location = new System.Drawing.Point(17, 276);
            this.txtGrossSalary.Name = "txtGrossSalary";
            this.txtGrossSalary.ReadOnly = true;
            this.txtGrossSalary.Size = new System.Drawing.Size(100, 25);
            this.txtGrossSalary.TabIndex = 11;
            // 
            // lblPensionDeduct
            // 
            this.lblPensionDeduct.AutoSize = true;
            this.lblPensionDeduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPensionDeduct.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionDeduct.Location = new System.Drawing.Point(17, 319);
            this.lblPensionDeduct.Name = "lblPensionDeduct";
            this.lblPensionDeduct.Size = new System.Drawing.Size(114, 19);
            this.lblPensionDeduct.TabIndex = 12;
            this.lblPensionDeduct.Text = "Pension Deduction";
            // 
            // txtPensionDeduct
            // 
            this.txtPensionDeduct.Location = new System.Drawing.Point(17, 342);
            this.txtPensionDeduct.Name = "txtPensionDeduct";
            this.txtPensionDeduct.ReadOnly = true;
            this.txtPensionDeduct.Size = new System.Drawing.Size(100, 25);
            this.txtPensionDeduct.TabIndex = 13;
            // 
            // lblTaxDeduct
            // 
            this.lblTaxDeduct.AutoSize = true;
            this.lblTaxDeduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxDeduct.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxDeduct.Location = new System.Drawing.Point(160, 254);
            this.lblTaxDeduct.Name = "lblTaxDeduct";
            this.lblTaxDeduct.Size = new System.Drawing.Size(99, 19);
            this.lblTaxDeduct.TabIndex = 14;
            this.lblTaxDeduct.Text = "Taxes Deducted";
            // 
            // txtTaxDeduct
            // 
            this.txtTaxDeduct.Location = new System.Drawing.Point(161, 276);
            this.txtTaxDeduct.Name = "txtTaxDeduct";
            this.txtTaxDeduct.ReadOnly = true;
            this.txtTaxDeduct.Size = new System.Drawing.Size(117, 25);
            this.txtTaxDeduct.TabIndex = 15;
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetPay.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.Location = new System.Drawing.Point(160, 319);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(54, 19);
            this.lblNetPay.TabIndex = 16;
            this.lblNetPay.Text = "Net Pay";
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(160, 342);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(118, 25);
            this.txtNetPay.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radSavingsNone);
            this.panel1.Controls.Add(this.radSavingsMedium);
            this.panel1.Controls.Add(this.radSavingsHighest);
            this.panel1.Location = new System.Drawing.Point(161, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 86);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radCategoryA);
            this.panel2.Controls.Add(this.radCategoryB);
            this.panel2.Location = new System.Drawing.Point(18, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 74);
            this.panel2.TabIndex = 19;
            // 
            // txtYearsService
            // 
            this.txtYearsService.Location = new System.Drawing.Point(17, 193);
            this.txtYearsService.Name = "txtYearsService";
            this.txtYearsService.Size = new System.Drawing.Size(96, 25);
            this.txtYearsService.TabIndex = 20;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(39, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "&CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(168, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // xyzGovernmentEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 433);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtYearsService);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.txtTaxDeduct);
            this.Controls.Add(this.lblTaxDeduct);
            this.Controls.Add(this.txtPensionDeduct);
            this.Controls.Add(this.lblPensionDeduct);
            this.Controls.Add(this.txtGrossSalary);
            this.Controls.Add(this.lblGrossSalary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPensionSaving);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblService);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "xyzGovernmentEmployees";
            this.Text = "XYZ Government Employees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radCategoryA;
        private System.Windows.Forms.RadioButton radCategoryB;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPensionSaving;
        private System.Windows.Forms.RadioButton radSavingsNone;
        private System.Windows.Forms.RadioButton radSavingsMedium;
        private System.Windows.Forms.RadioButton radSavingsHighest;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblGrossSalary;
        private System.Windows.Forms.TextBox txtGrossSalary;
        private System.Windows.Forms.Label lblPensionDeduct;
        private System.Windows.Forms.TextBox txtPensionDeduct;
        private System.Windows.Forms.Label lblTaxDeduct;
        private System.Windows.Forms.TextBox txtTaxDeduct;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtYearsService;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

