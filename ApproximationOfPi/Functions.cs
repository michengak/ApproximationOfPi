using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproximationOfPi
{

    // process 2.

    class Functions
    {
        public static double ProvideHypotenuse(Coordinates coordinates)
        {
            return Math.Sqrt(Math.Pow(coordinates.getX(), 2)
                + Math.Pow(coordinates.getY(), 2));
        }


    }


}
