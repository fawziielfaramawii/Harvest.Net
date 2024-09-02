using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Net.Core.confiration;

namespace Net.Core.Model
{
    public class companycontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=OMAR\\TEW_SQLEXPRESS;Database=DBcompanyDay3;Integrated Security=True; TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies(true);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()          // instead of the Configration File 
            //    .Property(a => a.Name)
            //    .IsRequired()
            //    .HasMaxLength(150)
            //    .HasColumnName("FullNmae");

            // new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Employee>());  // calling the configure api file 
            //* anothe way to call the configure api file  */
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Employee).Assembly);

            // Data seeding
            List<Department> departments = new List<Department>
            {
                new Department(){id=4,name="IT",location="mansoura"},
                new Department(){id=5,name="Hr",location="Cairo"},
                new Department(){id=6,name="Cs",location="Alex"},
                new Department(){id=7,name="Is",location="Aswan"},
            };
            modelBuilder.Entity<Department>().HasData(departments);

            //List<Employee> employees = new List<Employee>
            //{
            //    new Employee(){id=1,Name="omar",Salary=2000,Age=20},
            //    new Employee(){id=2,Name="mohamed",Salary=3000,Age=30},
            //    new Employee(){id=3,Name="ali",Salary=4000,Age=40},
            //    new Employee(){id=4,Name="Hassan",Salary=5000,Age=50}
            //};
            //modelBuilder.Entity<Employee>().HasData(employees);

            /* global Filter  */
            //modelBuilder.Entity<Employee>()
            //    .HasQueryFilter(a => a.isdeleted == false);

            /* relation one to one between add and emloyee */
            modelBuilder.Entity<Employee>()
                .HasOne(a => a.address)
                .WithOne(a => a.employee);

            modelBuilder.Entity<deptproject>()
                .HasKey(a => new { a.proid, a.departmentid });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Project> projects { get; set; }
    }
}
