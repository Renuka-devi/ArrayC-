using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public void hashTable()
        {
            //Hash table

            Hashtable newHashTable = new Hashtable();
            newHashTable.Add("India", "New Delhi");
            newHashTable.Add("US", "Washington, D.C");
            newHashTable.Add("Afghanistan", "Kabul");
            newHashTable.Add("Canada", "Ottawa");
            newHashTable.Add("Colombia", "Bogota");

            foreach (DictionaryEntry de1 in newHashTable)
            {
                Console.WriteLine("Country {0} and Capital {1} ", de1.Key, de1.Value);
            }

            // Removing the particular country
            var country = "India";
            newHashTable.Remove(country);

            //updating the particular country

            var updatingCountry = "Colombia";

            if(newHashTable.ContainsKey(updatingCountry))
            {
                newHashTable[updatingCountry] = "Bogotaaa";
            }

            foreach (DictionaryEntry de in newHashTable)
            {
                Console.WriteLine("Country {0} and Capital {1} ", de.Key, de.Value);

            }
        }

        public void stack()
        {
            Stack stack = new Stack();
            stack.Push("Ramesh");
            stack.Push("Akhil");
            stack.Push("Vishnu");

            foreach(var singleStack in stack)
            {
                Console.WriteLine("{0}", singleStack);
            }
            Console.WriteLine("count of stack elements: {0}", stack.Count);
            Console.WriteLine("Ramesh in the stack {0}", stack.Contains("Ramesh"));
            Console.WriteLine("Top most element is {0}", stack.Peek());
            Console.WriteLine(stack.Pop());
        }
        public static void getPositiveNegativeNumbers()
        {
            int[] numbers = { 2, 8, 6, -5, 4, -36 };
            int positiveCount = 0;
            int negativeCount = 0;
            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    negativeCount = negativeCount + 1;
                }
                else
                {
                    positiveCount = positiveCount + 1;
                }
            }
            Console.WriteLine("Negative number count = " + negativeCount);
            Console.WriteLine("Positive number count = " + positiveCount);
        }

        public static void arraySorting()
        {
            int[] numbers = { 8, 1, 5, 7, 3, 2, 7 };
            Array.Sort(numbers);
            foreach (int sortedArray in numbers)
            {
                Console.WriteLine(sortedArray);
            }
        }

        public static void arrayComparison()
        {
            //read an array from console


            //int size = 5;
            int[] firstArray = new int[5];
            int[] secondArray = new int[5];
            Console.WriteLine("Enter 5 numbers for array A");
            for (int i = 0; i < 5; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter 5 numbers for array B");
            for (int j = 0; j < 5; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());
            }
            bool areEqual = true;
            //Array comparison
            if (firstArray.Length == secondArray.Length)
            {
                for (int m = 0; m < firstArray.Length; m++)
                {
                    if (firstArray[m] != secondArray[m])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }
            else
            {
                areEqual = false;
            }

            if (areEqual == true)
            {
                Console.WriteLine("array's are equal");
            }
            else
            {
                Console.WriteLine("array's are not equal");
            }
        }

        public string checkPalindrom()
        {
            Console.WriteLine("Enter a string");
            String newString = Convert.ToString(Console.ReadLine());
            char[] characterArray = newString.ToCharArray();
            Array.Reverse(characterArray);
            String ReversedString = new string(characterArray);
            if (newString == ReversedString)
            {
                return "String is palindrom";
            }
            return "String is not palindrom";
        }

        public int countOfWord()
        {
            Console.WriteLine("Hello I am RENUKA");
            string sentence = "Hello I am RENUKA";
            //split the string usning split function 
            string[] splittedArray = sentence.Split(' ');
            return splittedArray.Length;
        }

        public static void unquieOfString()
        {
            Console.WriteLine("Enter a String");
            string newString1 = Convert.ToString(Console.ReadLine());
            // Convert string to array
            char[] newArray = newString1.ToCharArray();
            // Create a HashSet using HashSet class
            HashSet<char> uniqueHashSet = new HashSet<char>();
            foreach (char x in newArray)
            {
                //adding unique element to the hashset
                uniqueHashSet.Add(x);
            }

            // get the element of hashset using foreach
            foreach (var val in uniqueHashSet)
            {
                Console.WriteLine(val);
            }
        }
        public virtual int getNumber()
        {
            return 5;
        }
    }

    //Inheritance in samenamespace

    class Class4 : Class1
    {
        public decimal salary; private decimal yearOfExp;

        public Class4(decimal salary, decimal yearOfExp)
        {
            this.salary = salary;
            this.yearOfExp = yearOfExp;
        }

        public void getDetails()
        {
            Console.WriteLine("Salary: " + salary + "Year of experience: " + yearOfExp);
        }

        //Method overriding
        public override int getNumber()
        {
            //base keyword
            base.getNumber();
            return 10;
        }
        
    }
    class Users
    {
        public string name;
        public int id;

        public Users(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public override string ToString()
        {
            return "User: " + name + " " + id;
        }
    }
}
