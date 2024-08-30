using EFCore.Configrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class CompanyContext :DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-TT2AFSL\\SQLEXPRESS; Database =CompanyDataBase;Integrated Security =true ;TrustServerCertificate =true;");
            base.OnConfiguring(optionsBuilder);
        }
        #region ano traking
        //public CompanyContext()
        //    {
        //        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        //    }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeEntityTypeConfig).Assembly);
            modelBuilder.ApplyConfiguration(new AddressEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new DepartmentEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new projectEntityTypeConfigration());

            List<Department> departments = new List<Department>()
            {
            new Department(){Id =1,Name ="Hr" ,location ="mansoura" },
            new Department(){Id =2,Name ="CS" ,location ="Domiat" },
            new Department(){Id =3,Name ="IT" ,location ="Qahera" }
            };
            modelBuilder.Entity<Department>().HasData(departments);

            modelBuilder.Entity<Address>()
                .HasOne(a => a.Employee)
                .WithOne(a => a.Address);
            #region relation Betwwen Tables
            //modelBuilder.Entity<Department>()
            //            .HasMany(a => a.Employees)
            //            .WithOne(a => a.Department);



            //modelBuilder.Entity<Project>()
            //    .HasOne(a => a.Employee)
            //    .WithMany(a => a.Projects);
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
