using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HostService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WCFServiceTask.Service1));
            host.Open();
            Console.WriteLine("Host started at {0}", DateTime.Now.ToString());
            Console.ReadKey();
        }
    }
}
