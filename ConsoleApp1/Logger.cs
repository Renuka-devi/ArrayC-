using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Logger
    {
        public void log(string classname, string methodname, string errormessage)
        {
            Console.WriteLine("class name: " + classname + ", method name: " + methodname +", error message: " + errormessage);
        }

        public void log(string classname, string errormessage)
        {
            Console.WriteLine("class name: " + classname + ", error message: " + errormessage);
        }

        public void log(string errormessage)
        {
            Console.WriteLine("error message: " + errormessage);
        }

        public void log(string classname, string methodname, string dateandtime, string errormessage)
        {
            Console.WriteLine("class name: " + classname + ", method name: " + methodname + ", error message: " + errormessage + ", date and time: " + dateandtime);
        }
    }
}
