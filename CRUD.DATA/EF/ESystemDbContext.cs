using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Data.Entities;
using Microsoft.EntityFrameworkCore;
namespace CRUD.Data.EF
{
    public partial class EShopDbContext
    {
        
        public DbSet<sys_user_db> sys_user { get; set; }
        public DbSet<sys_user_role_db> sys_user_role { get; set; }

        public DbSet<sys_system_activities_db> sys_system_activities { get; set; }
        public DbSet<sys_role_db> sys_role { get; set; }
        public DbSet<sys_promotion_db> sys_promotion { get; set; }

        public DbSet<sys_product_tranlastion_db> sys_product_tranlastion { get; set; }
        public DbSet<sys_product_db> sys_product { get; set; }
        public DbSet<sys_permission_db> sys_permission { get; set; }
        public DbSet<sys_language_db> sys_language { get; set; }
        public DbSet<sys_function_db> sys_function { get; set; }
        public DbSet<sys_contact_db> sys_contact { get; set; }

        public DbSet<sys_categories_tranlastion_db> sys_categories_tranlastion { get; set; }
        public DbSet<sys_categories_db> sys_categories { get; set; }
        public DbSet<sys_cart_db> sys_cart { get; set; }
        public DbSet<sys_action_db> sys_action { get; set; }

        
        protected void ESystemTableBuilder(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<User>(entity =>
            //{

            //});
            OnModelCreatingPartial(modelBuilder);
        }

    }
}
