using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface InterfaceClass
    {
        bool authenticate();
    }

    public class FaceRecognitionAuthentication : InterfaceClass
    {
        public bool authenticate()
        {
            return true;
        }
    }

    public class FingerPrintAuthentication : InterfaceClass
    {
        public bool authenticate()
        {
            return true;
        }
    }

    public class PasswordAuthentication : InterfaceClass
    {
        public bool authenticate()
        {
            return true;
        }
    }

}
