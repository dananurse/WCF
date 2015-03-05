using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Client.localhost;
using Host;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Service Client";

            CreateHelloWorldProxy();

            return;

            CreateIndigoProxy();
        }

        private static void CreateHelloWorldProxy()
        {
            localhost.HelloWorldServiceClient proxy =
                new Client.localhost.HelloWorldServiceClient();

            try
            {
                string s = proxy.HelloWorld();
                Console.WriteLine(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Press <ENTER> to terminate.");
            Console.ReadLine();
        }

        private static void CreateIndigoProxy()
        {
            EndpointAddress ep = new EndpointAddress("http://localhost:8000/HelloIndigo/HelloIndigoService");

            IHelloIndigoService proxy = ChannelFactory<IHelloIndigoService>
                .CreateChannel(new BasicHttpBinding(), ep);

            string s = proxy.HelloIndigo();

            Console.WriteLine(s);
            Console.WriteLine("Press <ENTER> to terminate.");
            Console.ReadLine();
        }
    }
}
