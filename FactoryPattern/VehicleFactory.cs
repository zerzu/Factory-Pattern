using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    { 
        public static Ivehicle GetVehicle(int numTires)
        {
            switch (numTires)
            {
                case 4:

                    return new Car();

                case 2:
                case 3:
                    return new Motorcycle();

                default:
                    return new Car();



            }
        }
    }
}
