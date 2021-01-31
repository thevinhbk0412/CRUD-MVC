using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_cart")]
  
    public class sys_cart_db
    {
        public string id { get; set; }
        public string product_id { get; set; }
        public string quantity { get; set; }
        public string price { get; set; }

        public string create_date { get; set; }
        public string create_by { get; set; }
        public string update_date { get; set; }
        public string update_by { get; set; }
        public string description { get; set; }
    }
}
