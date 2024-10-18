using SimpleCompany.Data;
using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.DataAccessLayer.Repository.Contract;

namespace SimpleCompany.DataAccessLayer.Repository
{
	public class InsuranceCompanyRepository : GenericRepository<InsuranceCompany>, IInsuranceCompanyRepository
	{
		public InsuranceCompanyRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
