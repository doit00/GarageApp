using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    class Program
    {
        static void Main(string[] args)
        {

            X509Certificate cert = null;
            X509Store myCertStore = new X509Store(StoreName.My,StoreLocation.CurrentUser);
            myCertStore.Open(OpenFlags.ReadOnly);
            
            foreach (var c in myCertStore.Certificates)
            {
                Console.WriteLine("{0,-32}{1,32}", c.Subject, c.Thumbprint);
            }


        }
    }
}
