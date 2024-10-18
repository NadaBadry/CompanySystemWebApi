using SimpleCompany.Data;
using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.DataAccessLayer.Repository.Contract;

namespace SimpleCompany.DataAccessLayer.Repository
{
	public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
	{
		public DepartmentRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
