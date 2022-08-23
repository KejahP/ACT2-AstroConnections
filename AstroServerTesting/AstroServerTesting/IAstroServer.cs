using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AstroServerTesting
{
    [ServiceContract]
    public interface IAstroContract
    {
        [OperationContract]
        double AstroVelocity(double waveObs, double waveRest);

        [OperationContract]
        double AstroDistance(double angle);

        [OperationContract]
        double AstroKelvin(double celsius);

        [OperationContract]
        double AstroHorizion(double mass);
    }
}
