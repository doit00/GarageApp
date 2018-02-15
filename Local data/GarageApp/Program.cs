using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Car() { Make = "mercedes", Model = "w210" };
            var carInFile = new FileStream("car.bin", FileMode.OpenOrCreate);

            var formatter = new BinaryFormatter();
            formatter.Serialize(carInFile, f);
            carInFile.Close();

            f = null;

            carInFile = new FileStream("car.bin", FileMode.Open);
            var carFromFile = formatter.Deserialize(carInFile) as Car;

            Console.WriteLine(carFromFile.Make);


        }
    }
    [Serializable]
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

}
