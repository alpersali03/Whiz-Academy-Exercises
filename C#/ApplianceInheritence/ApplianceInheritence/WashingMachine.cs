using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplianceInheritence
{
    public class WashingMachine : Appliance
    {
        public WashingMachine(string brand, int power, int capacity) : base(brand, power)
        {
            Capacity = capacity;
        }
        public int Capacity {  get; set; }
        public void ShowDetails()
        {
            Console.WriteLine($"Марка: {Brand}, Мощност: {Power}W, Капацитет: {Capacity}kg");
        }
    }

}
