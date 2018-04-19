using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CarManagement
{
    class CarDM
    {
        // static Save method
        public static void Save(List<Car> listCar)
        {
            StreamWriter outputFile = File.CreateText("carlist.txt");

            foreach (Car newCar in listCar)
            {
                outputFile.WriteLine(newCar.Model);
                outputFile.WriteLine(newCar.Year.ToString("f"));
                outputFile.WriteLine(newCar.Color);
                outputFile.WriteLine(newCar.Mileage.ToString("f"));
            }

            outputFile.Close();
        }


        // static Load method
        public static List<Car> Load()
        {
            List<Car> listCar = new List<Car>();
            Car newCar;

            try
            {
                StreamReader inputFile = File.OpenText("carlist.txt");

                while (!inputFile.EndOfStream)
                {
                    newCar = new Car();

                    newCar.Model = inputFile.ReadLine();
                    newCar.Year = int.Parse(inputFile.ReadLine());
                    newCar.Color = inputFile.ReadLine();
                    newCar.Mileage = double.Parse(inputFile.ReadLine());

                    listCar.Add(newCar);  
                }

                inputFile.Close();

                return listCar;
            }

            catch
            {
                return listCar;
            }

        }

    }
}
