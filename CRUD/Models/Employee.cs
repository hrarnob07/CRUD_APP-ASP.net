using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string name { get; set; }
        public int Salary{ get; set; }
        public string Address { get; set; }
    }
}