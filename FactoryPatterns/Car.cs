using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FactoryPatterns
{
    class Car : IVehicles
    {
        public void Drive()
        {
            Console.WriteLine("building a new car");
        }
    }
}
