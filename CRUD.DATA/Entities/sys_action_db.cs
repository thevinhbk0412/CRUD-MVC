using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_action")]
  
    public class sys_action_db
    {
        public string id { get; set; }
        public string name { get; set; }
     
    }
}
