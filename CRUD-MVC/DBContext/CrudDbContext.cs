using CRUD_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.DBContext
{
    public partial class CrudDbContext :DbContext
    {
        public CrudDbContext(DbContextOptions<CrudDbContext> options) : base(options) { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            systemTableBuilder(modelBuilder);
            //OnModelCreatingPartial(modelBuilder);

        }
      
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
