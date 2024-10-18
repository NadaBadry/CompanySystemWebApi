using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.ServicesLayer.DTO.Project;

namespace SimpleCompany.ServicesLayer.Contract
{
	public interface IProjectService
	{
		IEnumerable<ProjectDto> GetAll();
		ProjectDto GetById(int id);
		void Insert(ProjectDto p);
		void Update(ProjectDto p);
		void Delete(int id);
	}
}
