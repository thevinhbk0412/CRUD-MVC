using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUD.Data.Entities
{
    [Table("sys_categories_tranlastion")]

    public class sys_categories_tranlastion_db
    {
        public string id { get; set; }
        public string category_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string detais { get; set; }
        public string seo_description { get; set; }
        public string seo_title { get; set; }
        public string langue_id { get; set; }
        public string create_date { get; set; }
        public string create_by { get; set; }
        public string update_date { get; set; }
        public string update_by { get; set; }
        public string status { get; set; }
    }
}
