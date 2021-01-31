using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_function")]
  
    public class sys_function_db
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string parent_id { get; set; }
        public string status { get; set; }
       
        public string sort_order { get; set; }
    }
}
