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
            int numberOfWheels = 4;
            int numberOfSeats = 5;
            
            string message= "Number of seats:" + numberOfSeats 
                    + " Number of wheels:" + numberOfWheels; 
            Console.WriteLine(message);

            //string - System.String

            string path1 = "C:\\users\\new";
            string path2 = @"C:\users\new";
            string formatted = String.Format("user:{0} computer:{1}", Environment.UserName, Environment.MachineName);


            var today = DateTime.Today.DayOfWeek;

            if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
            {
                Console.WriteLine("non-working day");
            }
            else
            {
                Console.WriteLine("working day");
            }


            switch (today)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("working day");
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }

            for (int i = 0; i <=10 ; i++)
            {
                Console.WriteLine(i);
            }



        }
    }
}
