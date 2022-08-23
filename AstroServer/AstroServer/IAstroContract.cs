using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Remoting.Messaging;
using AstroCalculations;

namespace AstroServer
{
    [ServiceContract]
    public interface IAstroContract
    {
        //star velocity calculation method
        [OperationContract]
        double AstroVelocity(double waveObs, double waveRest);

        //star distance calculation method
        [OperationContract]
        double AstroDistance(double angle);

        //kelvin temprature calcuation method
        [OperationContract]
        double AstroKelvin(double celsius);

        //Horizion calculation method
        [OperationContract]
        double AstroHorizion(double mass);
    }
}
