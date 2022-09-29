using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    static class VehicleFactory
    {
        public static IVehicles Vehicle(int numberOfTires)
        {
            switch (numberOfTires)
            {
                case 4:
                    return new Car();
                case 2:
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
