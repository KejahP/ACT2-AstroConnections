namespace AstroCalculations
{
    public class AstroCalc
    {
        /// <summary>
        /// Class Name: Star Velocity
        /// Description: Star velocity calculates the speed of a star can be reached, by getting the 
        ///              stars observed wavelength of a star and the rest wavelength of a star, the 
        ///              final calculation for determining the velocity is observed wavelength
        ///              - rest wavelength / rest wavelength * the speed of light. This method 
        ///              uses two input parameters of type double (Observed Wavelength and Rest 
        ///              Wavelength) and return a double which represents the velocity.
        /// ></returns>

        public double StarVelocity(double obsWave, double restWave)
        {

            double lightSpeed = 299792458;
            double velocity = ((obsWave - restWave) / restWave) * lightSpeed; 

            return velocity;
        }


        /// <summary>
        /// Class Name: Star Distance
        /// Description: The star distance calculates the distance between earth to a star using the 
        ///              earth’s parallax angle, the formular intakes the parallax angle and divides it into parsecs. 
        ///              This method has a single input parameter of type double (Arcseconds angle) and return a double.
        /// ></returns>
        public double StarDistance(double arcAng)
        {
            double distance = 1 / arcAng;
            return distance;
        }

        /// <summary>
        /// Class Name: Temprature Kelvin
        /// Description: This method converts a Celsius temperature into a Kelvin temperature, the kelvin is the standard 
        /// international unit of thermodynamic temperature. This is done by adding 273.15 to the current Celsius. 
        /// This method has a single input parameter of type double (temperature in Celsius) and returns a double 
        /// which is the temperature in degrees kelvin.
        /// ></returns>
        public double TempKelvin(double celsius)
        {
            double kelvin = 0;

            kelvin = celsius + 273.15;
            return kelvin;
        }


        /// <summary>
        /// Class Name: Event Horizon
        /// Description: This method calculates a black hole’s event horizon which is the boundary within a 
        /// black hole which no light can reach, this calculation is also known as a Schwarzschild radius. 
        /// This is done by getting a black holes mass * gravity constant * 2 / the speed of light ^ 
        /// (to the power of) 2. This method contains a single input parameter of type double (Blackhole Mass) 
        /// and return a double which is the event horizon in metres
        /// ></returns>
        public double EventHorizon(double blackMass)
        {
            double lightSpeed = 299792458;
            double dis = 0;

            double grav = 6.674 * Math.Pow(10, -11);
 
            dis = 2 * grav * blackMass / Math.Pow(lightSpeed, 2);


            return dis;
        }
    }
}