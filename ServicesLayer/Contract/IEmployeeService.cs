using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.ServicesLayer.DTO.Employee;

namespace SimpleCompany.ServicesLayer.Contract
{
	public interface IEmployeeService
	{
		IEnumerable<GetAllEmployeeDto> GetAll();
		GetAllEmployeeDto GetById(int id);
		void Insert(AddEmployeeDto employee);
		void Update(UpdateEmployee employee);
		void Delete(int id);
		//void save();
		
	}
}
