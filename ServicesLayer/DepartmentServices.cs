using Microsoft.AspNetCore.Http.HttpResults;
using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.DataAccessLayer.Repository;
using SimpleCompany.DataAccessLayer.Repository.Contract;
using SimpleCompany.ServicesLayer.Contract;
using SimpleCompany.ServicesLayer.DTO.Department;
using SimpleCompany.ServicesLayer.DTO.Employee;

namespace SimpleCompany.ServicesLayer
{
	public class DepartmentServices : IDepartmentService
	{
		private readonly IDepartmentRepository departmentRepository;
		public DepartmentServices(IDepartmentRepository _departmentRepository)
		{
			departmentRepository = _departmentRepository;
		}	
		public IEnumerable<DeptDto> GetAll()
		{
			return departmentRepository.GetAll().Select(d => new DeptDto
			{
				ID = d.ID,
				Name = d.Name,

			});
		}

		public DeptDto GetById(int id)
		{
			Department dept = departmentRepository.GetById(id);
			if (dept != null)
			{
				return new DeptDto
				{
					ID = dept.ID,
					Name = dept.Name,
				};
			}

			return null;
		}
		public void Insert(DeptDto d)
		{
			var dept = new Department
			{
				ID = d.ID,
				Name = d.Name,
			};
			departmentRepository.Insert(dept);
			departmentRepository.save();
		}
		public void Update(DeptDto department)
		{
			
				var d = new Department
				{
					ID= department.ID,
					Name = department.Name
				};

				departmentRepository.Update(d);
				departmentRepository.save();
			
		    
		}
		public void Delete(int id)
		{
			departmentRepository.Delete(id);
			departmentRepository.save();
		}

	}
}
