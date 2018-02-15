using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Linq2Objects();
            StructAndEnum();

        }

        private static void StructAndEnum()
        {
            Engine petrolEngine = new Engine();
            petrolEngine.CubicCapacity = 1995;
            petrolEngine.Fuel = FuelType.Petrol;
            petrolEngine.HorsePower = 205;
            petrolEngine.Transmission = TransmissionType.Manual;
        }

        private static void Linq2Objects()
        {
            var path = Environment.CurrentDirectory;
            var dir = new DirectoryInfo(path);

            var files = dir.GetFiles();
            var sizeMin = 1024;

            var queryCs =
                from f in files
                where f.Length > sizeMin
                select f;

            foreach (var f in queryCs)
            {
                Console.WriteLine(f.Name);
            }
        }
    }
    struct Engine
    {
        public FuelType Fuel { get; set; }
        public TransmissionType Transmission { get; set; }
        public int HorsePower { get; set; }
        public int CubicCapacity { get; set; }
    }
    enum FuelType
    {
        Petrol, Diesel, Electric, LPG, Hybrid
    }
    enum TransmissionType
    {
        Manual, Automatic, SemiAutomatic
    }
    
}
