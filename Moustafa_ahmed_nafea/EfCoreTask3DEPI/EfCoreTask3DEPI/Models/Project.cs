namespace EfCoreTask3DEPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProjectDepartment> ProjectDepartments { get; set; }
    }
}
