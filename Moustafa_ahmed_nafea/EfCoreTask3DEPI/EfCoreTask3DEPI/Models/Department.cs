namespace EfCoreTask3DEPI.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<ProjectDepartment> ProjectDepartments { get; set; }
    }
}
