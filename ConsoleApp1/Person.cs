using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public string name = "Renuka";
        public int age = 25;
        public string color;
        public Person(string color)
        {
            this.color = color;
        }
        public virtual void display()
        {
            Console.WriteLine("name: " + name + ", Age: " + age);
        }

        public int show()
        {
            return age;
        }
    }

    class Employees : Person
    {

        public Employees(string color) : base(color)
        {
            
        }
        // reimplementing the name prop using new keyword.
        public new string name = "SWATHI";

        //override the dispaly function
        public override void display()
        {
            Console.WriteLine("name: " + name + ", Age: " + age);
        }

        //reimplementing the method with new keyword
        public new void show()
        {
            Console.WriteLine("Age: " + age + ", color: " + color);
        }
    }
}
