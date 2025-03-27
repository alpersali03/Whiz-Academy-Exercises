using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass
{
    public class CarClass
    {
        private string brand;
        private string model;
        private int year;


        public CarClass(string model, string brand, int year){
            this.Model = model;
            this.Brand = brand;
            this.Year = year;
        }
        public CarClass(int year)
        {
            this.Year = year;
        }

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Brand value is null");
                }
                brand = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if(value < 2000)
                {
                    throw new ArgumentException("The year of the car should be beyond 2000 year");
                }
                year = value;   
            }
        }
        public void CarInfo()
        {
            Console.WriteLine("Our car brand is : " + this.Brand);
            Console.WriteLine("Our car model is : " + this.Model);
            Console.WriteLine("Our car year is : " + this.Year);
        }
    }
}
