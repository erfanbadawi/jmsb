namespace InClassAssignment
{
    partial class frmDental
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
            this.chkFirstVisit = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radOrthodonic = new System.Windows.Forms.RadioButton();
            this.radRestorative = new System.Windows.Forms.RadioButton();
            this.radPreventive = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCovered = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFirstVisit
            // 
            this.chkFirstVisit.AutoSize = true;
            this.chkFirstVisit.Location = new System.Drawing.Point(34, 39);
            this.chkFirstVisit.Name = "chkFirstVisit";
            this.chkFirstVisit.Size = new System.Drawing.Size(73, 17);
            this.chkFirstVisit.TabIndex = 0;
            this.chkFirstVisit.Text = "First Visit?";
            this.chkFirstVisit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOrthodonic);
            this.groupBox1.Controls.Add(this.radRestorative);
            this.groupBox1.Controls.Add(this.radPreventive);
            this.groupBox1.Location = new System.Drawing.Point(34, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of service";
            // 
            // radOrthodonic
            // 
            this.radOrthodonic.AutoSize = true;
            this.radOrthodonic.Location = new System.Drawing.Point(18, 91);
            this.radOrthodonic.Name = "radOrthodonic";
            this.radOrthodonic.Size = new System.Drawing.Size(77, 17);
            this.radOrthodonic.TabIndex = 2;
            this.radOrthodonic.TabStop = true;
            this.radOrthodonic.Text = "Orthodonic";
            this.radOrthodonic.UseVisualStyleBackColor = true;
            // 
            // radRestorative
            // 
            this.radRestorative.AutoSize = true;
            this.radRestorative.Location = new System.Drawing.Point(18, 54);
            this.radRestorative.Name = "radRestorative";
            this.radRestorative.Size = new System.Drawing.Size(108, 17);
            this.radRestorative.TabIndex = 1;
            this.radRestorative.TabStop = true;
            this.radRestorative.Text = "Major Restorative";
            this.radRestorative.UseVisualStyleBackColor = true;
            // 
            // radPreventive
            // 
            this.radPreventive.AutoSize = true;
            this.radPreventive.Location = new System.Drawing.Point(18, 20);
            this.radPreventive.Name = "radPreventive";
            this.radPreventive.Size = new System.Drawing.Size(127, 17);
            this.radPreventive.TabIndex = 0;
            this.radPreventive.TabStop = true;
            this.radPreventive.Text = "Preventive or Surgery";
            this.radPreventive.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(438, 86);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount paid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount Covered:";
            // 
            // lblCovered
            // 
            this.lblCovered.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCovered.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCovered.Location = new System.Drawing.Point(438, 142);
            this.lblCovered.Name = "lblCovered";
            this.lblCovered.Size = new System.Drawing.Size(100, 23);
            this.lblCovered.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(378, 212);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmDental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 275);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCovered);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkFirstVisit);
            this.Name = "frmDental";
            this.Text = "Dental Insurance";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFirstVisit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOrthodonic;
        private System.Windows.Forms.RadioButton radRestorative;
        private System.Windows.Forms.RadioButton radPreventive;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCovered;
        private System.Windows.Forms.Button btnCalculate;
    }
}

