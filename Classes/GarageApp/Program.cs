﻿using System;
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
            Garage myGarage = new Garage();
            var car1 = myGarage[0];
            var count = myGarage.CarCount;

            var allCars = myGarage.GetAllCars();

            //IComparable
            allCars.Sort();

            //IComparer
            IComparer<Car> makeComparer = new CarMakeComparer();
            allCars.Sort(makeComparer);



        }
    }


}
