using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewConsole;

namespace ConsoleApp1
{
    class Program
    {
        //private filed
        private string department = "IT";
        static void Main(string[] args)
        {

            //Search vowels from a given character array

            Console.WriteLine("Search vowels from a given character array");
            string[] characters = { "a", "v", "i", "s" };
            string[] vowels = new string[characters.Length];
            int index = 0;
            foreach (string i in characters)
            {
                switch (i)
                {
                    case "a":
                    case "i":
                    case "e":
                    case "o":
                    case "u":
                        vowels[index] = i;
                        index++;
                        break;
                    default:
                        break;
                }
            }
            foreach (string vowel in vowels)
            {
                Console.WriteLine(vowel);
            }

            // Get the count of positive and negative number count from an array
            Console.WriteLine("Get the count of positive and negative number count from an array");
            Class1.getPositiveNegativeNumbers();

            //Sort an array

            Console.WriteLine("Array sorting");
            Class1.arraySorting();

            //array comparison
            Class1.arrayComparison();

            //Check the string is palindrome or not

            Class1 obj = new Class1();
            Console.WriteLine(obj.checkPalindrom());

            // Count the number of words in a sentance.

            Console.WriteLine("Words Count is " + obj.countOfWord());

            //get unqiue characters of a string

            Class1.unquieOfString();

            // Creating object for Employee class and using the properties
            //same namespace
            Employee objs = new Employee();
            Console.WriteLine("id: " + objs.id + ", name: " + objs.name + ", email: " + objs.email);

            Program program = new Program();
            Console.WriteLine("Department: " + program.department);

            // create a class in another namespace

            Console.WriteLine("using class from different namespace");
            Class2 newObj = new Class2(10, "23563256325");
            Console.WriteLine("id: " + newObj.id + ", name: " + newObj.name + ", email: " + newObj.email);

            newObj.getAgePhone();

            SetterGetter Xobj = new SetterGetter();
            Xobj.X = 100;
            Console.WriteLine("Get value: " + Xobj.X);

            //Inheritance

            NewConsole.Class3 inheritObj = new Class3(25, "236542555");
            inheritObj.getAgePhone();
            string email = inheritObj.email;
            Console.WriteLine("Email Inherited from Class2" + email);
            inheritObj.Gender1 = "FEMALE";
            Console.WriteLine("GENDER: " + inheritObj.Gender1);


            // Inherit Class4 from Class1 (same namespace)
            Class4 inheritObj1 = new Class4(10000.500m, 3.5m);
            inheritObj1.getDetails();
            // We can't access the uniqueOfString function, Because static method can't access in instance reference.
            //inheritObj1.unquieOfString()
            inheritObj1.checkPalindrom();

            // method overriding
            Console.WriteLine("The number is: " + inheritObj1.getNumber());


            //ABSTRACT

            DerievedClass abstractObj = new DerievedClass();
            abstractObj.customMethod();
            abstractObj.newAbstractMethod();
            Console.WriteLine("The number is " + abstractObj.newAbstractMethod1());

            Employees emp = new Employees("BLACK");
            emp.display();
            emp.show();

        }
    }

    // Define a class Employee with fields id,name,email,department

    class Employee
    {
        // declaring new properties at Employee class
        public int id = 10;
        public string name = "Renuka"; public string email = "renuka@gmail.com";

    }

    class SetterGetter
    {
        private int x;

        public int X { 
            get => x; set => x = value; 
        }
    }

    // abstract class same namespace
    class DerievedClass : newAbstract
    {
        public override void newAbstractMethod()
        {
            Console.WriteLine("override abstract");
        }

        public override int newAbstractMethod1()
        {
            return 5;
        }
    }
}
