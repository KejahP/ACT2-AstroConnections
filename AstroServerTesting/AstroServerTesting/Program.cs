using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace AstroServerTesting
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("Client Started... \nConnecting To Server...");

            ChannelFactory<AstroServer> pipeFactory = new ChannelFactory<AstroServer>
            (new NetNamedPipeBinding(),new EndpointAddress("net.pipe://localhost/Astro"));
            
            AstroServer pipeProxy = pipeFactory.CreateChannel();


            Console.WriteLine(pipeFactory.State.ToString());
            Console.WriteLine(pipeProxy.AstroKelvin(27));
            
            //Console.WriteLine("Star Velocity: " + pipeProxy.AstroVelocity(500.1, 500) + 
            //    "\nStar Distance: "+ pipeProxy.AstroDistance(0.547) + 
            //    "\nKelvin: " + pipeProxy.AstroKelvin(27)
            //    + "\nEvent Horizon: "+ pipeProxy.AstroHorizion(8.2 * Math.Pow(10,36))
            //    );

        }
    }
}
