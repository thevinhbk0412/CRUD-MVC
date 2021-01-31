using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_contact")]
  
    public class sys_contact_db
    {
        public string id { get; set; }
        public string name { get; set; }

        public string phone { get; set; }
        public string email { get; set; }
        public string message { get; set; }

        public string status { get; set; }
    }
}
