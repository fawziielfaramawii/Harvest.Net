using ConsoleApp1.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.EmployeeConstr
{
	public class EmployeeTypeConfig:IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			builder.Property(a => a.Age)
				.HasComputedColumnSql("DATEDIFF(YEAR, [DateOfBirth], GETDATE())");
		}
	}
}