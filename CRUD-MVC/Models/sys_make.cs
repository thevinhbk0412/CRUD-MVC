using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.Models
{
    [Table("sys_make")]
    public class sys_make
    {
        public int? id { get; set; }
        public string name { get; set; }
    }
}
