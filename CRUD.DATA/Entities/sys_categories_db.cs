using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_categories")]
  
    public class sys_categories_db
    {
        public string id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string sort_order { get; set; }
        public string is_show_home { get; set; }
        public string parent_id { get; set; }
        public string status { get; set; }
        public string create_date { get; set; }
        public string create_by { get; set; }
        public string update_date { get; set; }
        public string update_by { get; set; }
        public string description { get; set; }
    }
}
