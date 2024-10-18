using Microsoft.EntityFrameworkCore;
using SimpleCompany.Data;
using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.DataAccessLayer.Repository.Contract;

namespace SimpleCompany.DataAccessLayer.Repository
{
	public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
	{
	
		public EmployeeRepository(ApplicationDbContext context) : base(context)
		{
		}
		public override IEnumerable<Employee> GetAll()
		{
			return _dbSet
				.Include(emp => emp.project)
				.Include(emp => emp.department)
				.Include(emp => emp.insuranceCompany);
		}
		//public override Employee Update(Employee employee)
		//{
		//	 _dbSet.
		//		Include(emp => emp.project)
		//		.Include(emp => emp.department)
		//		.Include(emp => emp.insuranceCompany);
		//}

	}
}
