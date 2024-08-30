using EFC_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace EFC_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyContext dbcontext = new CompanyContext();
            //var employee = new Employee() {
            //DateOfBirth= DateTime.Now.AddYears(-27),
            //Name="Karim",
            //DepartmentId=1
            //};
            //dbcontext.Emplyees.Add(employee);
            //dbcontext.Emplyees.ExecuteUpdate(a => a.SetProperty(a => a.Salary,b=>b.Salary + 2000));
            //dbcontext.SaveChanges();

            //globalfilter
            //var emps=dbcontext.Emplyees.IgnoreQueryFilters().ToList();
            //foreach (var e in emps)
            //{
            //    Console.WriteLine(e.Name);
            //}
            int e = 3;

            var emp= dbcontext.Emplyees.FromSql($"Exec  proc_GetEmployeeByID {e}").AsEnumerable().FirstOrDefault();
         
        }
    }
}
