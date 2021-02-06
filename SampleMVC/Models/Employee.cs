using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Employee
    {
        [Key, Column(Order =0)]
        public int PersonId { get; set; }
        [Key, Column(Order = 1)]
        public int CompanyId { get; set; }
        public int ProffessionId { get; set; }
        public DateTime HireDate  { get; set; }
        public Company Company { get; set; }
        public Person Person { get; set; }
        public Profession Profession { get; set; }
    }
}