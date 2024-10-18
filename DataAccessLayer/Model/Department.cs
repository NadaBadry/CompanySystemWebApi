namespace SimpleCompany.DataAccessLayer.Model
{
    public class Department
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public ICollection<Project>? Projects { get; set; }
    }
}
