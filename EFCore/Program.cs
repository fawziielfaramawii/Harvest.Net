using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyContext dbcontext = new CompanyContext();

            #region BulkUpdate Delet
            //delet fromDb
            //  dbcontext.Employees.Where(a=> a.Salary ==6000).ExecuteDelete();
            //update
            // dbcontext.Employees.Where(a => a.Salary == 7000).ExecuteUpdate(a=>a.SetProperty(p=> p.Salary ,a=> a.Salary+6500));
            #endregion
            #region softDelet
            //git non deleted data
            // var emp = dbcontext.Employees.Where(a=>a.IsDeleted ==false).ToList();
            //git all data deleted and non delated
            //var emp = dbcontext.Employees.IgnoreQueryFilters().ToList();
            #endregion
            #region stored Procedure
            //over dataBase
            //  var emp = dbcontext.Database.ExecuteSql($"Exec Proc_GetallemployeeId 3");
            //over Progarm
          //  int empid = 3;
            //var emp = dbcontext.Employees.FromSql($"Exec Proc_GetallemployeeId {empid}").FirstOrDefault();
            #endregion
        }
    }
}
