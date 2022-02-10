using AcademyA_CDO.Week3.CoreLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Week3.WCFService
{
    [ServiceContract]
    public interface IEmployeeService
    {//contiene la descrizione di quello che il service è in grado di offrire. 
     //restituisco un employee dato un id

        [OperationContract]
        Employee GetEmployee(string firstName, string lastName);

        [OperationContract]
        bool AddEmployee(Employee newEmployee);

        [OperationContract]
        IList<Employee> GetAllEmployees();

    }
}
