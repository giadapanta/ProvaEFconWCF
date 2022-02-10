using AcademyA_CDO.Week3.CoreLibrary.Entities;
using AcademyA_CDO.Week3.CoreLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyA_CDO.Week3.CoreLibrary.BusinessLayer
{
    public class NewBusinessLayer : IMainBusinessLayer //deve esporre le stesse prop 
    {
        public bool AddNewEmployee(Employee newEmployee)
        {
            //nuova logica. 
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(Employee newEmployee)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAllEmployes()
        {
            throw new NotImplementedException();
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
