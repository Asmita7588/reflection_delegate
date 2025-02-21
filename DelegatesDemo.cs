using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public delegate void PrintMessage(string message);

    public delegate void PrintGreetings(string message);

    public delegate void MenuFunction();

    public delegate int Calculate(int x, int y);
    internal class DelegatesDemo
    {

        public static void PrintToConsole(string message)
        {

            Console.WriteLine("Console :" + message);
        }



        public static void PrintToFile(string message)
        {

            Console.WriteLine("File :" + message);

        }


        public static void ShowDate()
        {

            Console.WriteLine("Current Date : " + DateTime.Now.ToShortDateString());

        }

        public static void ShowTime()
        {

            Console.WriteLine("Current Time : " + DateTime.Now.ToLongTimeString());

        }

        public static void Exit()
        {

            Console.WriteLine("Exiting the application..");

        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {

            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            
             return x / y;
        }
    }
}
