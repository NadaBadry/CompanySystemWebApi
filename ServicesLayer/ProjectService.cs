using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.DataAccessLayer.Repository;
using SimpleCompany.DataAccessLayer.Repository.Contract;
using SimpleCompany.ServicesLayer.Contract;
using SimpleCompany.ServicesLayer.DTO.Department;
using SimpleCompany.ServicesLayer.DTO.Project;

namespace SimpleCompany.ServicesLayer
{
	public class ProjectService : IProjectService
	{
		private readonly IProjectRepository projectRepository;
        public ProjectService(IProjectRepository _projectRepository)
        {
			projectRepository= _projectRepository;

		}
        public IEnumerable<ProjectDto> GetAll()
		{
			return projectRepository.GetAll().Select(p => new ProjectDto
			{
				Id = p.ID,
				Name = p.Name,

			});

		}

		public ProjectDto GetById(int id)
		{
			var project = projectRepository.GetById(id);
			if (project != null)
			{
				return new ProjectDto
				{
					Id = project.ID,
					Name = project.Name
				};
			}
			return null;
		}

		public void Insert(ProjectDto p)
		{
			var project = new Project
			{
				ID=p.Id,
				Name = p.Name
			};
			projectRepository.Insert(project);
			projectRepository.save();
		}

		public void Update(ProjectDto p)
		{
			var project = new Project
			{
				ID = p.Id,
				Name = p.Name
			};
			projectRepository.Update(project);
			projectRepository.save();
		}
		public void Delete(int id)
		{
			projectRepository.Delete(id);
			projectRepository.save();
		}

	}
}
