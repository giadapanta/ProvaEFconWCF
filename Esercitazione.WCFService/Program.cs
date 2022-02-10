using Esercitazione.WCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.SelfHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(
                typeof(BookService)
                        ))
            {
                host.Open();
                Console.WriteLine("Selfhosting started.");
                Console.WriteLine("Press any key to continue");

                Console.ReadKey();
            }
        }
    }
}
