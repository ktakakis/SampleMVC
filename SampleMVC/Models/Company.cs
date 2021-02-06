using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } 

    }
}