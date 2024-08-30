using EfCore.Configration;
using EfCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore
{
    public class CompanyContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ELFARAMAWY\\SQLEXPRESS01 ; database=EFCore ; Integrated Security =true ; Encrypt =false ; TrustServerCertificate = true;");
            optionsBuilder.UseLazyLoadingProxies(true);
            base.OnConfiguring(optionsBuilder);
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region connect Figuration 
            //connect Figuration 
            new EmployeeEntityTypeConfiguration().Configure(modelBuilder.Entity<Employee>());
            new ProjectEntityTypeConfiguration().Configure(modelBuilder.Entity<Project>());
            new DepartmentEntityTypeConfiguration().Configure(modelBuilder.Entity<Department>());
            //modelBuilder.ApplyConfiguration(new EmployeeEntityTypeConfiguration()) 
            #endregion;

            #region CompsitePrimeryKey

            //composite primarykey
            //modelBuilder.Entity<Department>()
            //    .HasKey(a => new { a.Name, a.Location });

            #endregion

            //Many to Many id exist other attribute over relation As Date 
            modelBuilder.Entity<DeptProject>().
                HasKey(x => new { x.ProjectId, x.DepartmentId });


            base.OnModelCreating(modelBuilder);
        }















        public virtual DbSet<Employee>Employees { get; set; }
        public virtual DbSet<Department>Departments { get; set; }
        public virtual DbSet<Project>Projects { get; set; }
    }
}
