using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;


namespace BuisnessLayer.Interfaces
{
   public interface IEmployeeService<T>where T : Employee
    {
        IEnumerable<T> GetEmployeeManager();
        IEnumerable<T> GetEmployeeOnVaccation();
        IEnumerable<object> GetEmployeeTasks(int id);
        
    }
}
