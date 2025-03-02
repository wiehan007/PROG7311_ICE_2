using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryCars
{
    class CarFactury
    {
        public ICar returnInstance;

        public ICar getVehicle(String CarType)
        {
            if (CarType.ToLower().Equals("sedan"))
            {
                returnInstance = new SedanCar();
            }
            else if (CarType.ToLower().Equals("sport"))
            {
                returnInstance = new SportsCar();
            }
            else if (CarType.ToLower().Equals("suv"))
            {
                returnInstance = new SUVCar();
            }
            return returnInstance;
        }
    }
}
