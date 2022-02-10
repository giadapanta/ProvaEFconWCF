using AcademyA_CDO.Week3.CoreLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyA_CDO.Week3.CoreLibrary.Interfaces
{
    public interface IEmployeeRepository: IRepository<Employee>
    {
        Employee GetEmployeeByCode(string code);

    }
}
