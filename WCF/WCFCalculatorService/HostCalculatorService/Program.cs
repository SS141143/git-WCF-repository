using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HostCalculatorService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WCFService.CalculatorService));
            host.Open();
            Console.WriteLine("Host started at {0}", DateTime.Now.ToString());
            Console.ReadKey();
        }
    }
}
