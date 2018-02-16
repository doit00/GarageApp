using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var cartype = typeof(Car);

            var allMembers = cartype.GetMembers();
            var carMembers = cartype.GetProperties();

            ProcessMembers(allMembers);

            ProcessMembers(carMembers);

        }

        private static void ProcessMembers(MemberInfo[] carMembers)
        {
            Console.WriteLine("\n----processing {0} members:--------\n",carMembers.Count());

            Console.WriteLine("{0,-16} {1,-16} {2}", "Name", "MemberType", "DeclaringType");
            Console.WriteLine("{0,-16} {1,-16} {2}", "".PadRight(16,'-'), "".PadRight(16, '-'), "".PadRight(16, '-'));
            foreach (var m in carMembers)
            {
                Console.WriteLine("{0,-16} {1,-16} {2}", m.Name, m.MemberType, m.DeclaringType.FullName);
            }

        }
    }
}
