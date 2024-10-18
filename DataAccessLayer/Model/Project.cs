namespace SimpleCompany.DataAccessLayer.Model
{
    public class Project
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

    }
}
