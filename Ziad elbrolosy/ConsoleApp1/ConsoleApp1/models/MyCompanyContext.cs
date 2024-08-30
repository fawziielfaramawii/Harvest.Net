using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
	public class MyCompanyContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server =DESKTOP-JH64ELJ\\SQLEXPRESS ; Database = myCompany;TrustServerCertificate=True ;Integrated Security= true ");
			base.OnConfiguring(optionsBuilder); base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employee>().HasQueryFilter(e => !e.IsDeleted);
			modelBuilder.Entity<Department>().HasQueryFilter(d => !d.IsDeleted);
			modelBuilder.Entity<Project>().HasQueryFilter(p => !p.IsDeleted);

			base.OnModelCreating(modelBuilder);
		}
		public DbSet<Employee> Employee { get; set; }
		public DbSet<Department> departments{ get; set; }
		public DbSet<Project> projects { get; set; }

	}
}
