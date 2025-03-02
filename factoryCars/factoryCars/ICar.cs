using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryCars
{
    public interface ICar
    {
        String getName();

        String getModel();

        String getTopSpeed();

        String getNumberOfSeats();

        String getCarPrice();

        String getWheelSize();
    }
}
