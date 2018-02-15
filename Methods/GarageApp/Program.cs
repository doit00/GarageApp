using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
        
            PrintMessage("hello");
        }
        static void PrintMessage(string msg)
        {
            PrintMessageInternal(msg, true);
        }

        private static void PrintMessageInternal(string msg, bool p)
        {
            Console.WriteLine(msg);
        }

    }
}
