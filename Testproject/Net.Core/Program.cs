using Microsoft.EntityFrameworkCore;
using Net.Core.Model;
using System;

namespace Net.Core.Model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            companycontext dbcontext = new companycontext();
            //var depart = new Department
            //{
            //    name = "Marketing",
            //    location = "Alex"

            //};
            //dbcontext.departments.Add(depart);
            //dbcontext.SaveChanges();

            //var emp = new Employee
            //{
            //    DateOfBirth = DateTime.Now.AddYears(-28),
            //    Name = "omar",
            //    DepartmentId = 2
            //};

            //dbcontext.employees.Add(emp);
            //dbcontext.SaveChanges();

            // * Bulk Delete 
            //dbcontext.departments.Where(a => a.id == 7).ExecuteDelete();

            // * Bulk Update
            //dbcontext.employees.Where(a => a.Salary == 4000).ExecuteUpdate(a => a.SetProperty(a => a.Salary, a => a.Salary + 2000));

            /* Applying global query filter */
            // var emps = dbcontext.employees.ToList();
            //var emps = dbcontext.employees.IgnoreQueryFilters().ToList();


            // Stored procedure 
            // var emp = dbcontext.Database.ExecuteSql(@"Exec proc_getemp_by_id 3");
            //var emp = dbcontext.employees.FromSql($"Exec proc_getemp_by_id 3").AsEnumerable().ToList();

            // Eager Loading
           // var depts = dbcontext.departments.Include(a => a.employees).ToList();
        
        }
    }
}