using Microsoft.EntityFrameworkCore;

namespace EfCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyContext db = new CompanyContext();
            //Employee employee = new Employee()
            //{
            //    Name = "ahmed",
            //    BirthDate = DateTime.Now.Date.AddYears(-40),
            //    DepartmentId = 1
            //};
            //db.Employees.Add(employee); 
            //db.SaveChanges();
            //Console.WriteLine("Done");

            #region BulkDelete,Update
            //Dont Need savechanges();
            // db.Employees.ExecuteUpdate(x => x.SetProperty(x => x.Salary, s => s.Salary + 2000));
            //db.Employees.Where(x => x.Age ==23).ExecuteDelete();
            //Console.WriteLine("Done"); 
            #endregion
            #region GlobalQueryFilter
            //var emps = db.Employees.ToList();
            ////var emps = db.Employees.IgnoreQueryFilters().ToList();
            //foreach (var emp in emps)
            //{
            //    Console.WriteLine(emp.Name);
            //}

            ;
            #endregion

            #region Procedure
            //Execute Proc
            /* var emps = db.Employees.FromSql($"exec Proc_Employee").AsEnumerable().ToList();*/
            #endregion

            var emps = db.Departments
                .Include(x => x.Employees)
                   .ToList();
             







            Console.ReadKey();
        }
    }
}
