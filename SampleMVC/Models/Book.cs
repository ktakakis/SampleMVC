using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Person Person { get; set; }
    }
}