using SimpleCompany.DataAccessLayer.Model;

namespace SimpleCompany.ServicesLayer.DTO.Employee
{
	public class GetAllEmployeeDto
	{
		public int ID { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Salary { get; set; }
		public string Email { get; set; } = string.Empty;
		public string? Address { get; set; }
		public string? departmentName { get; set; }
		public string? projectName { get; set; }
		public string? insuranceCompanyName { get; set; }= string.Empty;
		//public int insuranceCompanyID { get; set; }

	}
}
