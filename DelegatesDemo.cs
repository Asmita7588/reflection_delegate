using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public delegate void PrintMessage(string message);
    internal class DelegatesDemo
    {

        public static void PrintToConsole(string message)
        {
            Console.WriteLine(message);
        }

    }

    
}
