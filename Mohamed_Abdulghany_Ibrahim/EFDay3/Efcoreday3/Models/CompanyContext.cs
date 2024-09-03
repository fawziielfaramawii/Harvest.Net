using Efcoreday3.Configrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcoreday3.Models
{
    public class CompanyContext :DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AMR-GREEN\\SQLEXPRESS; Database=DBCompanyDay3; Integrated Security=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().
            //    Property(a => a.Name).
            //    IsRequired().
            //    HasMaxLength(150)
            //    //.HasColumnType("nvarchar(50)")

            //   . HasColumnName("FullName");


             new EmployeeEntityTypeConfiguration().Configure(modelBuilder.Entity<Employee>());

            //modelBuilder.Entity<project>()
            //    .Property(a => a.Date)
            //    //.HasDefaultValue(new DateTime().Date); 
            //    .HasDefaultValueSql("GETDATE()");

            // create relation with department and employee from fluent Api one to many
            //modelBuilder.Entity<Employee>().
            //    HasOne(a => a.Department). 
            //    WithMany(a => a.Employees);

            // composite pk
            //modelBuilder.Entity<Department>()
            //    .HasKey(a => new { a.Name, a.Location });

            //data seeding
            List<Department> departments = new List<Department>()
            {

             new Department(){Id =4,Name="Ai" ,Location="Mansoura"},
             new Department(){Id =5,Name="HR" ,Location="Assiut"},
             new Department(){Id =6,Name="ML" ,Location="Menouf"},
             


            };
           
            //data seeding
            modelBuilder.Entity<Department>().HasData(departments);
            //glopal filter
            modelBuilder.Entity<Employee>().
                HasQueryFilter(a => a.Isdeleted == false);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet <Employee>Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<project> Projects { get; set; }



    }
}
