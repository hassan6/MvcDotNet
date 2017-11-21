using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
 public   class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<Employee>Employees { get; set; }
    }
}
