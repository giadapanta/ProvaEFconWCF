using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Week3.WCFService;

namespace AcademyA_CDO.Week3.SelfHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(
                typeof(EmployeeService)
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
