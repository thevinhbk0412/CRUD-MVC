using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_role")]
  
    public class sys_role_db
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
   
    }
}
