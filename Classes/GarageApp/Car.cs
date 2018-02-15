using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    class Car:IComparable<Car>
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public SegmentType Segment { get; set; }

        public int CompareTo(Car other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return String.Format("Id:{0}, Make:{1}, Model:{2}",Id,Make, Model);
        }
    }
}
