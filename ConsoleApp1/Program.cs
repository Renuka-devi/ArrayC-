using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
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
        }
    }
}
