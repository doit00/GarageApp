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
            //int - System.Int32
            int NumberOfEmployees = 1000;
            int Seats = 1141;
            var Remaining = Seats - NumberOfEmployees;

            Console.WriteLine(Remaining);


        }
    }
}
