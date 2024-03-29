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
            string[] characters = { "a", "v", "i", "s" };
            foreach (string i in characters)
            {
                switch(i)
                {
                    case "a":
                        if(i == "a")
                        {
                            string[] vowels = { i };
                            Console.WriteLine("vowel is " +vowels);
                        }
                        break;
                    case "i":
                        if (i == "i")
                        {
                            string[] vowels = { i };
                        }
                        break;
                    case "e":
                        if (i == "e")
                        {
                            string[] vowels = { i };
                        }
                        break;
                    case "o":
                        if (i == "o")
                        {
                            string[] vowels = { i };
                        }
                        break;
                    case "u":
                        if (i == "u")
                        {
                            string[] vowels = { i };
                        }
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
