using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClass
{
    public class ProductClassEx
    {
        private string name;
        private double price;
        private double discount;

        public ProductClassEx(string name, double price, double discount)
        {
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public double Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }
        public double CalculateFinalPrice()
        {
            double calculateDiscount = this.Discount / 100;
            double discountPrice = this.Price * calculateDiscount;
            return this.Price - discountPrice;

        }
    }
}
