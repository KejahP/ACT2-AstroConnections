using AstroServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroCalculations; 

namespace AstroServer
{
   public class AstroServer : IAstroContract
   {
        AstroCalc calc = new AstroCalc();

        public double AstroVelocity(double waveObs, double waveRest)
        {
            //reads in and runs the star velocity method from the AstroCalculations
            //and returns the result 
            return calc.StarVelocity(waveObs, waveRest);
        }

        public double AstroDistance(double angle)
        {
            //reads in and runs the StarDistance method from the AstroCalculations
            //and returns the result 
            return calc.StarDistance(angle);
        }

        public double AstroKelvin(double celsius)
        {
            //reads in and runs the tempKelvin method from the AstroCalculations
            //and returns the result 
            return calc.TempKelvin(celsius);
        }

        public double AstroHorizion(double mass)
        {
            //reads in and runs the event horizion method from the AstroCalculations
            //and returns the result 
            return calc.EventHorizon(mass);
        }
    }
}
