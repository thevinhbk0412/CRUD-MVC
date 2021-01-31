using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_promotion")]

    public class sys_promotion_db
    {
        public string id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string from_date { get; set; }
        public string to_date { get; set; }
        public string apply_for_all { get; set; }
        public string discount_pertion { get; set; }
        public string discount_amount { get; set; }
        public string product_ids { get; set; }
        public string product_categories_ids { get; set; }
        public string create_date { get; set; }
        public string create_by { get; set; }
        public string update_date { get; set; }
        public string update_by { get; set; }
        public string status { get; set; }
    }
}
