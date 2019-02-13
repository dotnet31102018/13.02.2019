using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1302
{
    static class MyConsole
    {
        public static int size = 1;

        static MyConsole()
        {
            Console.WriteLine("Static console is created!");
        }

        internal static void MyWriteLine(string msg)
        {
            Console.WriteLine($"*** {msg} ***");
        }

        // non static room
        // in static class everything MUST be static

        //int currentSize;
        //public MyConsole()
        //{

        //}
    }
}
