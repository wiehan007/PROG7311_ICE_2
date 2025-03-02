using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryCars
{
    internal class SUVCar : ICar
    {
        public string getCarPrice()
        {
            return "R 450,000";
        }

        public string getModel()
        {
            return "Q5 2024";
        }

        public string getName()
        {
            return "Audi Q5";
        }

        public string getNumberOfSeats()
        {
            return "5";
        }

        public string getTopSpeed()
        {
            return "250km/h";
        }

        public string getWheelSize()
        {
            return "118 to 21 Inches";
        }


    }
}
