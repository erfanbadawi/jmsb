namespace CarManagement
{
    partial class CarAddForm
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
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(38, 44);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(53, 18);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(38, 94);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 18);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(38, 141);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 18);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileage.Location = new System.Drawing.Point(38, 192);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(63, 18);
            this.lblMileage.TabIndex = 3;
            this.lblMileage.Text = "Mileage:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(173, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(41, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 38);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(152, 42);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(116, 20);
            this.txtModel.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(152, 94);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(116, 20);
            this.txtYear.TabIndex = 7;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(152, 141);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(116, 20);
            this.txtColor.TabIndex = 8;
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(152, 193);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(116, 20);
            this.txtMileage.TabIndex = 9;
            // 
            // carAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 383);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Name = "carAddForm";
            this.Text = "Add a New Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtMileage;
    }
}