using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsole
{
    public class Class2
    {
        public int id = 10;
        public string name = "Renuka"; public string email = "renuka@gmail.com";
        public int age; public string phone;
        private string Gender;


        public Class2(int age, string phone)
        {
            name = "akhil"; email = "akhil@xminds.com";
            this.age = age;
            this.phone = phone;
        }

        public string Gender1 { get => Gender; set => Gender = value; }

        //static method can't access the instance member.
        public void getAgePhone() //Here we can't use the static method. No need to create instance for static method. 
        {
            Console.WriteLine("Age: " + age + ", Phone: " + phone);
        }
    }

    // INHERITANCE

    class Class3 : Class2
    {
        public Class3(int age, string phone) : base(age, phone)
        {
            // Constructor body, if needed
        }


    }
}
