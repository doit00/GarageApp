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
            CarDb db = new CarDb();
            var firstCar = db.Cars.FirstOrDefault();

            var query1 = from d in firstCar.Documents
                        where d.Name == "insurance"
                        select d;

            var query2 = firstCar.Documents.Where(d => d.Name == "insurance").Select(d => d);



        }
    }
}
