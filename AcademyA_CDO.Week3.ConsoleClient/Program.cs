using EmployeeServficesSelfHosted;
using System;

namespace AcademyA_CDO.Week3.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //mi serve un client -> employeeserviceclient è un ogg creato nella classe reference che si è auto generata
            EmployeeServiceClient client = new EmployeeServiceClient(); //ho dichiarato e inizializzato il client
            var employees =client.GetAllEmployees();
           foreach(Employee emp in employees)
            {
                Console.WriteLine($"Employee {emp.FirstName} {emp.LastName}");
            }


            Console.WriteLine("Press any key to continue: ");
            Console.ReadLine();
        }
    }
}
