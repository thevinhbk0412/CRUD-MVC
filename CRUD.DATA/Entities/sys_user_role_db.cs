using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_user_role")]
  
    public class sys_user_role_db
    {
      
        public string user_id{ get; set; }
        public string role_id { get; set; }
     
    }
}
