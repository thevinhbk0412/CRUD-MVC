using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_language")]
  
    public class sys_language_db
    {
        public string id { get; set; }
        public string name { get; set; }
        public string is_default { get; set; }
   
    }
}
