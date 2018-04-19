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
    public partial class MainForm : Form
    {
        // Creating a List object, referenced by the listCar variable to hold Car objects
        List<Car> listCar = new List<Car>();

        public MainForm()
        {
            InitializeComponent();
        }

        //Load event
        private void MainForm_Load(object sender, EventArgs e)
        {
            listCar = CarDM.Load();
        }

        //"Add Car" click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car newCar;

            // Create an instance of the AddForm class.	
            CarAddForm addForm = new CarAddForm();

            newCar = addForm.GetInfo();

            if ((newCar.Model != "") && (newCar.Year != 1899) && (newCar.Color != "") && (newCar.Mileage != -1))
            {
                listCar.Add(newCar);
            }
            else
            {
                MessageBox.Show("New car cannot be added. Inputs were missing and/or not entered correctly.", "Attention");
            }

        }

        //"View Cars" click event
        private void btnView_Click(object sender, EventArgs e)
        {
            // Create an instance of the ViewForm class.
            CarViewForm viewForm = new CarViewForm();

            viewForm.ViewCars(listCar);

        }

        //"Save" click event
        private void btnSave_Click(object sender, EventArgs e)
        {
            CarDM.Save(listCar);
        }
    }
}
