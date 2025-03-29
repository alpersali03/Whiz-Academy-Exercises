using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Person
    {
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            }
        }

        public Person(string name, int age) 
        {
            this.Name = name;
            this.Age = age; 
        }
       
    }
}
