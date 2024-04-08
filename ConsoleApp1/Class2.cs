using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ConsoleApp1;

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

    class User
    {
        int userId;  string name; string email; string mobile;
        public User(int userId, string name, string email, string mobile)
        {
            this.userId = userId;
            this.name = name;
            this.email = email;
            this.mobile = mobile;
        }

        public void validate()
        {
            //var result = Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            var result = Regex.IsMatch(email, @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");

            var phoneNumRegex = Regex.IsMatch(mobile, @"^\d{ 5} ([- ] *)\d{ 6}$");

            if(result == false)
            {
                throw new CustomExceptionClass("Email Not Match");
            } else if(phoneNumRegex == false)
            {
                throw new CustomExceptionClass("Mobile Not Match");
            } else
            {
                Console.WriteLine("name " + name + ", Email " + email + ", Phone number " + mobile);
            }

        }
    }
}
