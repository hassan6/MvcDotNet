using BuisnessLayer.Interfaces;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Implementations
{
    public class DepartmentService : IBaseRepository<Department>
    {
        private MyAppContext _db;
        public DepartmentService(MyAppContext db)
        {
            _db = db;
        }

        public bool Create(Department o)
        {
            _db.Department.Add(o);
           return _db.SaveChanges()>0?true:false;
        }

        public bool Delete(Department id)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            return _db.Department.Where(s => s.Id == id).SingleOrDefault();
        }

        public IEnumerable<Department> Get()
        {
            return _db.Department;
        }

        public bool Update(Department o)
        {
            throw new NotImplementedException();
        }
    }
}
