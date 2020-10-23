using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TMS.Project.Data;

namespace TMS.Persistance
{
   public class TMSDataContext :DbContext 
    {
         public DbSet<User> Users { get; set; }
         public DbSet<Booking> Bookings{ get; set; }
         public DbSet<Payment> Payments{ get; set; }
         public DbSet<Role> Roles { get; set; }
         public DbSet<UserRole> UserRoles{ get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TMSProject;Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
