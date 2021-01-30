using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_MVC.Models;
using Microsoft.EntityFrameworkCore;
namespace CRUD_MVC.DBContext
{
    public partial class CrudDbContext
    {
        public DbSet<sys_make> sys_makes { get; set; }
        protected void systemTableBuilder(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<User>(entity =>
            //{

            //});
            OnModelCreatingPartial(modelBuilder);
        }

    }
}
