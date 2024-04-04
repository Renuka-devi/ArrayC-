using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class newAbstract
    {
        public abstract void newAbstractMethod();
        public abstract int newAbstractMethod1();

        public void customMethod()
        {
            Console.WriteLine("A CUSTOM METHOD OF ABSTRACT CLASS");
        }
    }
}
