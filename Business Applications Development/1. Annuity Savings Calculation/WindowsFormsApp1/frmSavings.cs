using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSavings : Form
    {
        public frmSavings()
        {
            InitializeComponent();
        }

        decimal monthlySaving, interestAnnual, interestCompound, balanceTotal;
        int monthNo = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        { 
            if (decimal.TryParse(txtMonthlySavings.Text, out monthlySaving))
            {
                if (decimal.TryParse(txtAnnualInterestPercentage.Text, out interestAnnual))
                {
                    if (interestAnnual >= 0)
                    {
                        interestAnnual = interestAnnual / 1200; // to get the percentage of monthly interest.
                        monthNo ++; //with each click, one month is recorded.
                        interestCompound= 0; //this amount is set to zero at start and will carry on in future calculations.
                        
                        for (int i = 1; i <= monthNo; i++)
                        {
                            monthlySaving += monthlySaving * interestAnnual;  //monthly savings and interest will add up after each month.
                            balanceTotal = monthlySaving + interestCompound; //the previous amount + the compounded interest is added to total balance.
                            interestCompound = balanceTotal; //total balance is assigned to compound variable since the future payment, will have an interest compounded of last total balance.
                            txtMonthNumber.Text = monthNo.ToString();
                            txtBalance.Text = balanceTotal.ToString("c");
                        }
                                            
                    }
                else
                {
                    MessageBox.Show("Annual interest must be equal to or greater than zero");
                }
              }
              else
              {
                MessageBox.Show("Please enter a numerical value for the interest rate");
              }
            }
            else
            {
              MessageBox.Show("Enter a numerical value for your monthly savings");
            }
        }
    }
}
