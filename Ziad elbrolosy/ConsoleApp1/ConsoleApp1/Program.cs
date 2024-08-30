using ConsoleApp1.models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			MyCompanyContext companyContext = new MyCompanyContext();
			var employees = companyContext.Employee
				.FromSqlRaw("EXEC GetEmployeesWithIdGreaterThan5 @p0", 4)
				.AsEnumerable()
				.ToList();
		}
	}
}