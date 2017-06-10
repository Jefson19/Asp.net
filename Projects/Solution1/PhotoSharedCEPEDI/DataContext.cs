using PhotoShared.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharedCEPEDI.DataAccess
{
   public class DataContext : DbContext
    {

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions
                .Remove<PluralizingTableNameConvention>();
        }
    }
    
}
