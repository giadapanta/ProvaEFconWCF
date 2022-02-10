using AcademyA_CDO.Week3.CoreLibrary.Entities;
using AcademyA_CDO.Week3.CoreLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyA_CDO.Week3.CoreLibrary.BusinessLayer
{
    public class MainBusinessLayer : IMainBusinessLayer
    {
        //ninjection dependeces -> inietto la dipendenza senza sapere che effettivamente ce l'ho
        //creo una classe copiata e deve essere così e basta -> installo il pacchetto ninject alla corelibrary.
        private IEmployeeRepository _employeeRepository;
        public MainBusinessLayer()
        {
            _employeeRepository = DependencyContainer.Resolve<IEmployeeRepository>();  //metodo
        }
        public MainBusinessLayer(IEmployeeRepository repo)
        {
            _employeeRepository = repo;      
        }
        public bool AddNewEmployee(Employee newEmployee)
        {
            if(newEmployee == null)
                return false;
            return _employeeRepository.Add(newEmployee);
        }

        public bool DeleteEmployee(Employee newEmployee)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAllEmployes()
        {
            return _employeeRepository.Fetch().ToList();
        }

        public Employee GetEmployeeByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(Employee newEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
