using SimpleCompany.Data;
using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.DataAccessLayer.Repository.Contract;

namespace SimpleCompany.DataAccessLayer.Repository
{
	public class ProjectRepository : GenericRepository<Project>, IProjectRepository
	{
		public ProjectRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
