using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class EmployeeDbContext :DbContext
    {
        DbSet<Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<CRUD.Models.Employee> Employees { get; set; }
    }
}