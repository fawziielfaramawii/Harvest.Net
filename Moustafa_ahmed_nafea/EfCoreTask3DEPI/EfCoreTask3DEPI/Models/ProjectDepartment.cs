namespace EfCoreTask3DEPI.Models
{
    public class ProjectDepartment
    {
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
