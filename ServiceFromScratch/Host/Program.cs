using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Service Host";

            using (ServiceHost host = new ServiceHost(typeof(HelloIndigo.HelloIndigoService),
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
