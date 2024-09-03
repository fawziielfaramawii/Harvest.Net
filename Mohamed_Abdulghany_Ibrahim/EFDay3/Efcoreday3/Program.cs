using Efcoreday3.Models;
using Microsoft.EntityFrameworkCore;

namespace Efcoreday3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CompanyContext dbcontext = new CompanyContext();
            //var Employee=new Employee
            //{
            //    DateOfBirth =  DateTime.Now.AddYears(2),
            //    Name = "morad",

            //    Salary = 9000 ,
            //    DepartmentId=2


            //};
            //dbcontext.Employees.Add(Employee);
            //dbcontext.SaveChanges(); 
            //  dbcontext.Employees.Where(a => a.DepartmentId > 4).ExecuteDelete();
            //  dbcontext.Employees.ExecuteUpdate(a => a.SetProperty(p => p.Salary, a => a.Salary + 2000));
            // var emps = dbcontext.Employees.ToList();
            // var emps1 = dbcontext.Employees.IgnoreQueryFilters().ToList();

            int empid = 4;
            var emp = dbcontext.Employees.FromSql($"Exec Proc_GetEmployeeById {empid}").FirstOrDefault();
            Console.ReadKey();

        }
    }
}
