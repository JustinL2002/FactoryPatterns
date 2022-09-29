using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    internal class Motorcycle : IVehicles
    {
        public void Drive()
        {
            Console.WriteLine("building a motorcycle");
        }
    }
}
