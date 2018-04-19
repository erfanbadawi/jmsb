using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagement
{
    public partial class CarAddForm : Form
    {
        // Creating a Car object.
        Car auto;

        public CarAddForm()
        {
            InitializeComponent();
        }

        //The Add click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            auto = new Car();

            // Temporary variables to hold the year and mileage
            int carYear;
            double carMileage;

            // Getting all properties

            if ((int.TryParse(txtYear.Text, out carYear)) && (txtYear.Text != null))
            {
              if ((double.TryParse(txtMileage.Text, out carMileage)) && (carMileage >= 0))
              {
                    auto.Model = txtModel.Text;
                    auto.Color = txtColor.Text;        
                    auto.Mileage = carMileage;

                    if ((carYear >= 1900) && (carYear <= 9999))
                    auto.Year = carYear;
                    else
                    {
                        MessageBox.Show("Years must be 4 digits and must not be below the year 1900.", "Please try again.", MessageBoxButtons.RetryCancel);
                    }    
              }           
              else
              {
                    MessageBox.Show("Mileage can only be zero or a positive value.", "Please try again.", MessageBoxButtons.RetryCancel);
              }
            }

            if ((auto.Model != null) && (auto.Year != 1899) && (auto.Color != null) && (auto.Mileage != -1))
            {
                txtModel.Text = "";
                txtYear.Text = "";
                txtColor.Text = "";
                txtMileage.Text = "";
            
                this.Close();
            }
        }

        //GetInfo Method
        public Car GetInfo()
        {
            this.ShowDialog();
            return auto;
        }

        //The Cancel click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
