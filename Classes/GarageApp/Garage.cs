using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    class Garage
    {
        private List<Car> cars = new List<Car>();
        public Garage()
        {
            cars.Add(new Car() { Id = 0, Make = "Ford", Model = "Fiesta" });
            cars.Add(new Car() { Id = 1, Make = "Fiat", Model = "Bravo" });
            cars.Add(new Car() { Id = 2, Make = "Ford", Model = "Kuga" });

        }
        //Garage indexer
        public Car this[int index]
        {
            get { return cars.Where(c => c.Id == index).FirstOrDefault(); }
        }
        public int CarCount
        {
            get
            {
                return cars.Count;
            }
        }
        public List<Car> GetAllCars()
        {
            return cars;
        }

    }
}
