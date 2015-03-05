using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Service Host";

            CreateHelloWorldHost();
            return;

            CreateIndigoHost();
        }

        private static void CreateHelloWorldHost()
        {
            using (ServiceHost host = new ServiceHost(typeof (HelloWorldService)))
            {
                host.Open();
                Console.WriteLine("Host Running\r\n<ENTER> to terminate.");
                Console.ReadLine();
            }
        }

        private static void CreateIndigoHost()
        {
            using (ServiceHost host = new ServiceHost(typeof (HelloIndigo.HelloIndigoService),
                new Uri("http://localhost:8000/HelloIndigo")))
            {
                host.AddServiceEndpoint(typeof (HelloIndigo.IHelloIndigoService),
                    new BasicHttpBinding(), "HelloIndigoService");

                host.Open();

                Console.WriteLine("Host Running\r\nPress <ENTER> to terminate.");
                Console.ReadLine();
            }
        }
    }
}
