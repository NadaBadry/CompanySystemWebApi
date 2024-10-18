using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.ServicesLayer.DTO.Department;

namespace SimpleCompany.ServicesLayer.Contract
{
	public interface IDepartmentService
	{
		IEnumerable<DeptDto> GetAll();
		DeptDto GetById(int id);
		void Insert(DeptDto department);
		void Update(DeptDto department);
		void Delete(int id);
	}
}
