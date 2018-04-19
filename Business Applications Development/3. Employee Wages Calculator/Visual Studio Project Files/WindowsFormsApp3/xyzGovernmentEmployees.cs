using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class xyzGovernmentEmployees : Form
    {
        public xyzGovernmentEmployees()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           const decimal taxLowIncome = 0.30m, taxModerateIncome = 0.35m, taxHighIncome = 0.40m;
           const decimal pensionSavingsNone = 0.00m, pensionSavingsMedium = 0.03m, pensionSavingsHighest = 0.05m;
           decimal grossSalary = 0.00m, taxDeduct = 0.00m, pensionDeduct = 0.00m, netPay;
           int yearsService;
           if (int.TryParse(txtYearsService.Text, out yearsService))
           {
              if (( yearsService >= 0 ) && ( yearsService <= 4))
              {
                    if (radCategoryA.Checked)
                    {
                        grossSalary = 45000.00m;
                    }
                    else if (radCategoryB.Checked)
                    {
                        grossSalary = 52000.00m;
                    }
                    else
                    {
                        MessageBox.Show("Please select employee's category.");
                    }
              }
              else if ((yearsService >= 5) && (yearsService <= 9))
              {
                    if (radCategoryA.Checked)
                    {
                        grossSalary = 50000.00m;
                    }
                    else if (radCategoryB.Checked)
                    {
                        grossSalary = 60000.00m;
                    }
                    else
                    {
                        MessageBox.Show("Please select employee's category.");
                    }
              }
              else if ((yearsService >= 10) && (yearsService <= 14))
              {
                    if (radCategoryA.Checked)
                    {
                        grossSalary = 55000.00m;
                    }
                    else if (radCategoryB.Checked)
                    {
                        grossSalary = 67000.00m;
                    }
                    else
                    {
                        MessageBox.Show("Please select employee's category.");
                    }
              }
              else if ((yearsService >= 15) && (yearsService <= 19))
              {
                    if (radCategoryA.Checked)
                    {
                        grossSalary = 58000.00m;
                    }
                    else if (radCategoryB.Checked)
                    {
                        grossSalary = 74000.00m;
                    }
                    else
                    {
                        MessageBox.Show("Please select employee's category.");
                    }
              }
              else if (yearsService > 19)
              {
                    if (radCategoryA.Checked)
                    {
                        grossSalary = 60000.00m;
                    }
                    else if (radCategoryB.Checked)
                    {
                        grossSalary = 80000.00m;
                    }
                    else
                    {
                        MessageBox.Show("Please select employee's category.");
                    }
              }
              else
              {
                  MessageBox.Show("Please write a positive integer value for the employee's years of service.");
              }

            } 
           else
           {
              MessageBox.Show("Please write an integer value for the employee's years of service.");
           }

           if (grossSalary < 55000m)
           {
                taxDeduct = taxLowIncome * grossSalary;
           }
           else if ((grossSalary >= 55000m) && (grossSalary < 70000m))
           {
                taxDeduct = taxModerateIncome * grossSalary;
           }
           else
           {
                taxDeduct = taxHighIncome * grossSalary;
           }


            if (radSavingsNone.Checked)
           {
              pensionDeduct = pensionSavingsNone * grossSalary;
           }
           else if (radSavingsMedium.Checked)
           {
              pensionDeduct = pensionSavingsMedium * grossSalary;
           }
           else if (radSavingsHighest.Checked)
           {
              pensionDeduct = pensionSavingsHighest * grossSalary;
           }
           else
           {
              MessageBox.Show("Please select a pension saving plan.");
           }

           txtGrossSalary.Text = grossSalary.ToString("c");
           txtTaxDeduct.Text = taxDeduct.ToString("c");
           txtPensionDeduct.Text = pensionDeduct.ToString("c");
           netPay = grossSalary - taxDeduct - pensionDeduct;
           txtNetPay.Text = netPay.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGrossSalary.Text = "";
            txtTaxDeduct.Text = "";
            txtPensionDeduct.Text = "";
            txtNetPay.Text = "";
            txtYearsService.Text = "";
            radCategoryA.Checked = false;
            radCategoryB.Checked = false;
            radSavingsHighest.Checked = false;
            radSavingsMedium.Checked = false;
            radSavingsNone.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
