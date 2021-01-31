using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_user")]
  
    public class sys_user_db
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string dob { get; set; }
        public string full_name { get; set; }
        public string last_login_date { get; set; }
        public string status { get; set; }
    }
}
