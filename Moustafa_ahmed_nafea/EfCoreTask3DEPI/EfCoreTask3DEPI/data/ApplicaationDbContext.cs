using EfCoreTask3DEPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask3DEPI.data
{
    public class ApplicaationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\ProjectModels ; Database = DBCompanyDay3 ; Integrated Security = true ; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectDepartment>()
                .HasKey(p => new { p.DepartmentId, p.ProjectId });

            modelBuilder.Entity<Employee>()
                      .Property(e => e.Age)
                      
                      .HasComputedColumnSql("DATEDIFF(YEAR, BirthDate, GETDATE())");

            modelBuilder.Entity<Employee>()
                .HasQueryFilter(e => !e.IsDeleted); 

            modelBuilder.Entity<Department>()
                .HasQueryFilter(d => !d.IsDeleted); 

            modelBuilder.Entity<Project>()
                .HasQueryFilter(p => !p.IsDeleted); 
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
         public DbSet<Project> Projects { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ProjectDepartment> ProjectDepartments { get; set; }


    }
}
