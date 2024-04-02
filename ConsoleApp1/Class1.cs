using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public static void getPositiveNegativeNumbers()
        {
            int[] numbers = { 2, 8, 6, -5, 4, -36 };
            int positiveCount = 0;
            int negativeCount = 0;
            foreach(int num in numbers)
            {
                if(num < 0)
                {
                    negativeCount = negativeCount + 1;
                } else
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
            foreach(int sortedArray in numbers)
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
            for(int i=0; i < 5; i++)
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
            } else
            {
                areEqual = false;
            }

            if(areEqual == true)
            {
                Console.WriteLine("array's are equal");
            } else
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
            if(newString == ReversedString)
            {
                return "String is palindrom";
            }
            return "String is not palindrom";
        }
    }
}
