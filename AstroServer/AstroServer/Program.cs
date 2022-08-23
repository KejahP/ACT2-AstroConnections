using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AstroServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AstroServer),
            new Uri [] { new Uri("net.pipe://localhost") }))
            {
                host.AddServiceEndpoint(typeof(IAstroContract), new NetNamedPipeBinding(), "Astro");

                host.Open();
                Console.WriteLine("The Astro Business server is now online. If you wish to exit please press enter");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}
