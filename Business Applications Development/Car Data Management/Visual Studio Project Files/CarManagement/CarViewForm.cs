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
    public partial class CarViewForm : Form
    {
        List<Car> listOfCars;

        public CarViewForm()
        {
            InitializeComponent();
        }

        public void ViewCars(List<Car> listCar)
        {
            foreach (Car newCar in listCar)
            {
                listOfCars = listCar;
                lstCars.Items.Add(newCar.DisplayInfo());
            }

            this.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
