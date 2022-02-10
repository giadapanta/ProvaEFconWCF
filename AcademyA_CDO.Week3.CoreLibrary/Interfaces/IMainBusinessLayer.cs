using AcademyA_CDO.Week3.CoreLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyA_CDO.Week3.CoreLibrary.Interfaces
{
    public interface IMainBusinessLayer
    {
        IList<Employee> GetAllEmployes();
        Employee GetEmployeeById(string id);    
        Employee GetEmployeeByCode(string code);
        bool AddNewEmployee(Employee newEmployee);
        bool UpdateEmployee(Employee newEmployee);
        bool DeleteEmployee(Employee newEmployee);

    }
}
