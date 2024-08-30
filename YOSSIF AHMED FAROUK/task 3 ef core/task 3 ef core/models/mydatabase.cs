using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_3_ef_core.config;

namespace task_3_ef_core.models
{
    public class mydatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = YOSSIF-FAROUK\\MSSQLSERVER02; Database = day3core; TrustServerCertificate=True ; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            new employeeentitytypeconfigration().Configure(modelBuilder.Entity<employee>());


            modelBuilder.Entity<addrsses>()
                    .HasOne(a => a.employee)
                    .WithOne(a => a.addrsse);

           

            modelBuilder.Entity<dep_pro>()
                .HasKey(a => new { a.projectId, a.DepartmentClass1id });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<employee> Employees { get; set; }
        public DbSet<DepartmentClass1> DepartmentClass1s { get; set; }
        public DbSet<project> projects { get; set; }
    }
}
