using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_product")]
  
    public class sys_product_db
    {
        public string id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string original_price { get; set; }
        public string stock { get; set; }
        public string view_cout { get; set; }
        public string create_date { get; set; }
        public string create_by { get; set; }
        public string update_date { get; set; }
        public string update_by { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string seo_alias { get; set; }
    }
}
