using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryCars
{
    class SedanCar: ICar
    {
        public string getCarPrice()
        {
            return "R650,000";
        }

        public string getModel()
        {
            return "A6 2024";
        }

        public string getName()
        {
            return "Audi A6";
        }

        public string getNumberOfSeats()
        {
            return "5";
        }

        public string getTopSpeed()
        {
            return "240km/h";
        }

        public string getWheelSize()
        {
            return "19 to 21 Inches";
        }
    }
}
