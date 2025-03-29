using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class RebtalCar
    {
        private string carModel;
        private bool isRented;

        public RebtalCar()
        {
            this.IsRented = false;
        }
        public string CarModel
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }
        public bool IsRented
        {
            get
            {
                return isRented;
            }
            set
            {
                isRented = value;
            }
        }
        public void RentCar()
        {
            IsRented = true;
        }
        public void ReturnCar()
        {
            IsRented = false;
        }
    }
}
