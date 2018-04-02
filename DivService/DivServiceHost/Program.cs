using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DivServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(DivService.Service1)))
            {
                host.Open();
                Console.WriteLine("Host open, service started");
                Console.ReadLine();
            }
        }
    }
}
