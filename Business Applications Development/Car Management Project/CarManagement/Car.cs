using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement
{
    public class Car
    {
        // Private Fields 
        private string _model;
        private int _year;
        private string _color;
        private double _mileage;

        // Constructor for all fields
        public Car()
	    {
	     	_model = "";
            _year = 1899;
 	        _color = "";
 	        _mileage = -1;
        }

        // Properties to access those fields
        public string Model
        {
        get { return _model; }
        set { _model = value; }
        }
        public int Year
        {
        get { return _year; }
        set { _year = value; }
        }
        public string Color
        {
        get { return _color; }
        set { _color = value; }
        }
        public double Mileage
        {
        get { return _mileage; }
        set { _mileage = value; }
        }

        // DisplayInfo Method
        public string DisplayInfo()
        {
        return "Model:  " + Model + ",  Year:  " + Year + ",  Color:  " + Color + ",  Mileage:  " + Mileage;
        }

    }
}
