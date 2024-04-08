using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CustomExceptionClass : Exception
    {
        public CustomExceptionClass(string message) : base(message) {
        }
        
    }
}
