using AcademyA_CDO.Week3.CoreLibrary;
using AcademyA_CDO.Week3.CoreLibrary.BusinessLayer;
using AcademyA_CDO.Week3.CoreLibrary.Entities;
using AcademyA_CDO.Week3.CoreLibrary.Interfaces;
using ACADEMYA_CDO.Week3.Core.Mock.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.WCFService
{
    public class EmployeeService : IEmployeeService
    {
        //serve il mainBusinessLayer perchè non conosco le entità ecc
        private IMainBusinessLayer _mainBL; //uso l'interfaccia per la questione delle dependences ninjection
        public EmployeeService()
        {
            DependencyContainer.Register<IMainBusinessLayer, MainBusinessLayer>(); //registro che quando
            //chiamo imainbus mi deve restituire l'implementazione mainbusin ,stessa cosa per la riga sotto

            //newbusiness -> quello che modifico è la riga 21: al posto di mainbusiness metto newbusiness...
            //stess cosa se c'è un altro repository andando a modificare solo mockEmployee in mockQualcosaltro

            DependencyContainer.Register<IEmployeeRepository,MockEmployeeRepository>();

            _mainBL=DependencyContainer.Resolve<IMainBusinessLayer>(); //restituisci l'implementazione associata a Imainbus
            //e mettila in _mainBL
        }

        public bool AddEmployee(Employee newEmployee)
        {
            return _mainBL.AddNewEmployee(newEmployee);
        }

        public IList<Employee> GetAllEmployees()
        {
           return _mainBL.GetAllEmployes();
        }

        public Employee GetEmployee(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
