using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ProjectCalculator : Form
    {
        public ProjectCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstProfit.Items.Clear();
            decimal initialInvestment, yearlyRevenue, yearlyExpense;
            decimal yearlyProfit = 0.00m;
            int breakEvenYear=0;
            if (decimal.TryParse(txtInitialInvestment.Text, out initialInvestment))
               {
                if (decimal.TryParse(txtYearlyRevenue.Text, out yearlyRevenue))
                   {
                    if(decimal.TryParse(txtYearlyExpenses.Text, out yearlyExpense))
                    {
                        yearlyProfit = yearlyRevenue - yearlyExpense;
                        if ((initialInvestment / yearlyProfit) % 1 == 0)
                        {
                            breakEvenYear = Convert.ToInt16(initialInvestment / yearlyProfit);
                        }
                        else if ((initialInvestment / yearlyProfit) < 1)
                        {
                            breakEvenYear = 1;
                        }
                        else
                        {
                            breakEvenYear = Convert.ToInt16(initialInvestment / yearlyProfit);
                            breakEvenYear += 1;
                        }
                
                        txtBreakEvenYear.Text = breakEvenYear.ToString(""); 
                    }
                    else
                    {
                        MessageBox.Show("Yearly expenses must be in numerical value.");
                    }
                }
                else
                {
                    MessageBox.Show("Yearly revenue must be a zero or positive numerical value");
                }
            }
            else
            {
                MessageBox.Show("Please enter a numerical value for your monthly savings");
            }

        }

        private void btnDoubleBE_Click(object sender, EventArgs e)
        {
            decimal initialInvestment, yearlyRevenue, yearlyExpense;
            decimal yearlyProfit = 0.00m, cumulativeProfit = 0.0m;
            int breakEvenYear = 0;
            if (decimal.TryParse(txtInitialInvestment.Text, out initialInvestment))
            {
                if (decimal.TryParse(txtYearlyRevenue.Text, out yearlyRevenue))
                {
                    if (decimal.TryParse(txtYearlyExpenses.Text, out yearlyExpense))
                    {
                        if (int.TryParse(txtBreakEvenYear.Text, out breakEvenYear))
                        {
                            yearlyProfit = yearlyRevenue - yearlyExpense;
                            initialInvestment *= (-1);
                            for (int i = 1; i <= (2 * breakEvenYear); i++)
                            {
                                cumulativeProfit = initialInvestment + (i * yearlyProfit) ;
                                lstProfit.Items.Add(i + ": " + cumulativeProfit.ToString("c"));
                            }
                        }
                        else
                       {
                            MessageBox.Show("Yearly expenses must be in numerical value.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yearly expenses must be in numerical value.");
                    }
                }
                else
                {
                    MessageBox.Show("Yearly revenue must be a zero or positive numerical value");
                }
            }
            else
            {
                MessageBox.Show("Please enter a numerical value for your monthly savings");
            }

        }
   
    }
}
