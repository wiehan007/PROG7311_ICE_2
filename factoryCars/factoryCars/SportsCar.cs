using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryCars
{
    internal class SportsCar: ICar
    {
        public string getCarPrice()
        {
            return "R1,8000,000";
        }

        public string getModel()
        {
            return "R8 V10 Performance Quattro 2024";
        }

        public string getName()
        {
            return "Audi R8 V10";
        }

        public string getNumberOfSeats()
        {
            return "2";
        }

        public string getTopSpeed()
        {
            return "330km/h";
        }

        public string getWheelSize()
        {
            return "19 to 20 Inches";
        }
    }
}
