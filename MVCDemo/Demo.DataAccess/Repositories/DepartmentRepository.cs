using Demo.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Repositories
{
    internal class DepartmentRepository
    {
        private readonly AppDbContext _dbContext;

        public DepartmentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //CRUD operations
        public Department? GetByID(int ID, AppDbContext dbContext)
        {
            var department = dbContext.Departments.Find(ID);
            return department;

        }
    }
}
