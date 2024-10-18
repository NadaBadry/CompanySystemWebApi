namespace SimpleCompany.DataAccessLayer.Model
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Salary { get; set; }
        public string Email { get; set; } = string.Empty;
        public string? Address { get; set; }
        public int departmentID { get; set; }
        public Department? department { get; set; }
        public int projectID { get; set; }

        public Project? project { get; set; }
        public int insuranceCompanyID {  get; set; }

		public InsuranceCompany? insuranceCompany { get; set; }
    }
}
