using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroCalculations
{
    internal class AstroCalculations
    {
        public double StarVelocity(double obsWave, double restWave)
        {

            double lightSpeed = 299792458;
            double velocity = lightSpeed * (obsWave / restWave);

            return velocity;
        }


        public double StarDistance(double arcAng)
        {
            double distance = 1 / arcAng;
            return distance;
        }

        public double TempKelvin(double celsius)
        {
            double kelvin = 0;

            kelvin = celsius + 273.15;

            return kelvin;   
        }


        public double EventHorizon(double blackMass)
        {
            double lightSpeed = 299792458;
            double dis = 0;
            double grav = 0;

            dis = 2 * (grav * blackMass) / Math.Sqrt(lightSpeed);

            return dis;
        }
    }
}
