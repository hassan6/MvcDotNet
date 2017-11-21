using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class Employee : Base
    {
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department EmployeeDepartment { get; set; }

        public Employee() : base()
        {

        }
        public Employee(string firstname, string lastname)
        {
            Employee obj = new Employee();
            FirstName = firstname;
            LastName = lastname;
        }



    }
}
