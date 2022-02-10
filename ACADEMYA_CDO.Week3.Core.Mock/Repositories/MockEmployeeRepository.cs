using AcademyA_CDO.Week3.CoreLibrary.Entities;
using AcademyA_CDO.Week3.CoreLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACADEMYA_CDO.Week3.Core.Mock.Repositories
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        //simula una base dati, quindi:
        private List<Employee> _employees = new List<Employee>() { 
            new Employee {Id="1", EmployeeCode="EMP001", FirstName="Dante", LastName="Alighieri"},            
            new Employee {Id="2", EmployeeCode="EMP002", FirstName="Francesco", LastName="Petrarca"},
            new Employee {Id="3", EmployeeCode="EMP003", FirstName="Mario", LastName="Rossi"},
            new Employee {Id="4", EmployeeCode="EMP004", FirstName="John", LastName="Smith"},
        };
        
        public bool Add(Employee newItem)
        {
           var exists =_employees.Exists(e =>e.EmployeeCode == newItem.EmployeeCode);
            if (exists)
                throw new Exception($"Employee with code: {newItem.EmployeeCode} already exists");
            _employees.Add(newItem);
            return true;
        }

        public bool DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Fetch(Func<Employee, bool> filter = null)
        {
           //controllo se il filtro è null
           if(filter == null)
                return _employees;
            return _employees.Where(filter); //where prende un func di employee e bool 
        }

        public Employee GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByCode(string code)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee updatedItem)
        {
            throw new NotImplementedException();
        }
    }
}
