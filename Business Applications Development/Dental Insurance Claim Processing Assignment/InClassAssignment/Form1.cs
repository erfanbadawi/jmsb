using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InClassAssignment
{
    public partial class frmDental : Form
    {
        public frmDental()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal eligibleCoverage = 0.00m, paidAmount;
            decimal deductibleFirstVisit = 50m;
            decimal reimbursedServicePercentage = 0.50m, reimbursedServiceMaximum = 1750m, reimbursedOrthodonicMaximum = 2500m;

            if (decimal.TryParse(txtAmount.Text, out paidAmount) && paidAmount > 0)
            {
                if (radPreventive.Checked || radRestorative.Checked || radOrthodonic.Checked)
                {
                    if (radPreventive.Checked)
                    {
                        eligibleCoverage += paidAmount;
                    }

                    if (radRestorative.Checked)
                    {
                        eligibleCoverage += reimbursedServicePercentage * paidAmount;
                    }

                    if (radOrthodonic.Checked)
                    {
                        eligibleCoverage += reimbursedServicePercentage * paidAmount;
                        if (eligibleCoverage > reimbursedOrthodonicMaximum)
                        {
                            eligibleCoverage = reimbursedServiceMaximum;
                        }
                    }


                    if (eligibleCoverage > reimbursedServiceMaximum && !radOrthodonic.Checked)
                    {
                        eligibleCoverage = reimbursedServiceMaximum;
                    }

                    if (chkFirstVisit.Checked)
                    {
                        eligibleCoverage += deductibleFirstVisit;
                    }

                    if (eligibleCoverage > paidAmount)
                    {
                        eligibleCoverage = paidAmount;
                    }

                    lblCovered.Text = eligibleCoverage.ToString("c");
                }
                else
                {
                    MessageBox.Show("Please select one type of the services.");
                }
            }
            else
            {
                MessageBox.Show("The value entered as 'Amount Paid' is incorrect.");
            }
        }
    }
}
