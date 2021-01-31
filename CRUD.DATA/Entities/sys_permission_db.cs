using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_permission")]
  
    public class sys_permission_db
    {
        public string id { get; set; }
        public string role_id { get; set; }
        public string function_id { get; set; }
        public string action_id { get; set; }
    }
}
