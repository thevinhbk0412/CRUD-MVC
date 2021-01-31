using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_system_activities")]
  
    public class sys_system_activities_db
    {
        public string id { get; set; }
        public string action_name { get; set; }
        public string action_date { get; set; }
        public string function_id { get; set; }
        public string user_id { get; set; }
        public string client_ip { get; set; }
       
    }
}
