using EFC_Project.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_Project.Model
{
    public class CompanyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\local;Database=DbCompany;Integrated Security=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
         
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Department> departmentList = new List<Department>() {
            
                new Department(){Id=7,Name="IT",Location="mansoura"},
                new Department(){Id=4,Name="IS",Location="cairo"},
                new Department(){Id=5,Name="CS",Location="alex"},
                new Department(){Id=6,Name="HR",Location="menoufia"}

            };
            modelBuilder.Entity<Department>().HasData(departmentList);
            modelBuilder.Entity<Employee>().HasQueryFilter(a => a.IsDeleted == false);






            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EmployeeEntityTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new DepartmentEntityTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new ProjectEntityTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new AddressEntityTypeConfiguration());
            
        }
        public DbSet<Employee> Emplyees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
