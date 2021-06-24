using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Classes
{
    class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public int Year { get; set; }
        public double CurrentValue { get; set; }

        public Car()
        {
            Id = 0;
            Make = "";
            Model = "";
            Registration = "";
            Year = 0;
            CurrentValue = 0;
        }

        public Car(int _id,string _make,string _model,string _registration,int _year,double _currentValue)
        {
            Id = _id;
            Make = _make;
            Model = _model;
            Registration = _registration;
            Year = _year;
            CurrentValue = _currentValue;
        }

        public double GetCurrentValue(int _id)
        {
            if(Id == _id)
            {
                return CurrentValue;
            }else
            { return 0; }
        }

        public int GetYearOfCar(int _id)
        {
            if (Id == _id)
            {
                return Year;
            }
            else
            { return 0; }
        }

        public string GetFullInfo(int _id)
        {
            if (Id == _id)
            {
                return "Id : " + Id+ "\nMake : " + Make + "\nModel : " + Model + "\nRegistration : " + Registration + "\nYear : " + Year + "\nCurrentValue : " + CurrentValue;
            }
            else
            { return ""; }
        }
    }
}
