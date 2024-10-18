using SimpleCompany.DataAccessLayer.Model;

namespace SimpleCompany.ServicesLayer.DTO.Employee
{
	public class AddEmployeeDto
	{
		//public int ID { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Salary { get; set; }
		public string Email { get; set; } = string.Empty;
		public string? Address { get; set; }
		public int departmentID { get; set; }
		public int projectID { get; set; }
		public int insuranceCompanyID { get; set; }
	}
}
