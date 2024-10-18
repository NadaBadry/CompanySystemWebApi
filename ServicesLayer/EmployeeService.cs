using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.DataAccessLayer.Repository;
using SimpleCompany.DataAccessLayer.Repository.Contract;
using SimpleCompany.ServicesLayer.Contract;
using SimpleCompany.ServicesLayer.DTO.Employee;

namespace SimpleCompany.ServicesLayer
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IEmployeeRepository employeeRepository;
        public EmployeeService(IEmployeeRepository _employeeRepository)
        {
			employeeRepository = _employeeRepository;

		}
        public IEnumerable<GetAllEmployeeDto> GetAll()
		{
			return employeeRepository.GetAll()
				.Select(emp => new GetAllEmployeeDto
				{
					ID = emp.ID,
					Name = emp.Name,
					Email = emp.Email,
					Address = emp.Address,
					Salary = emp.Salary,
					insuranceCompanyName = emp.insuranceCompany.Name,
					projectName=emp.project.Name,
					departmentName=emp.department.Name

				});
		}

		public GetAllEmployeeDto GetById(int id)
		{
			Employee emp= employeeRepository.GetById(id);
			if(emp!=null)
			{
				return new GetAllEmployeeDto
				{
					ID = emp.ID,
					Name = emp.Name,
					Email = emp.Email,
					Address = emp.Address,
					Salary = emp.Salary,
					insuranceCompanyName = emp.insuranceCompany?.Name,
					projectName = emp.project?.Name,
					departmentName = emp.department?.Name

				};
			}
			return null;
		}

		public void Insert(AddEmployeeDto employee)
		{
			var emp = new Employee
			{
				Name = employee.Name,
				Email = employee.Email,
				Address = employee.Address,
				Salary = employee.Salary,
				insuranceCompanyID = employee.insuranceCompanyID,
				projectID = employee.projectID,
				departmentID = employee.departmentID
			};

			employeeRepository.Insert(emp);
			employeeRepository.save();
		}

		public void Update(UpdateEmployee employee)
		{
			var emp = new Employee
			{
				ID= employee.ID,
				Name = employee.Name,
				Email = employee.Email,
				Address = employee.Address,
				Salary = employee.Salary,
				insuranceCompanyID=employee.insuranceCompanyID,
				departmentID=employee.departmentID,
				projectID=employee.projectID
			};
			employeeRepository.Update(emp);
			employeeRepository.save();

		}
		public void Delete(int id)
		{
			employeeRepository.Delete(id);
			employeeRepository.save();
		}

	}
}
