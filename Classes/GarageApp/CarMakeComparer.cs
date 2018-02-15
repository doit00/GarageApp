using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    class CarMakeComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Make.CompareTo(y.Make);
        }
    }
}
