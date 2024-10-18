using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.ServicesLayer.DTO.InsuranceCompany;

namespace SimpleCompany.ServicesLayer.Contract
{
	public interface IInsuranceCompanyService
	{
		IEnumerable<CompanyDto>GetAll();
		CompanyDto GetById(int id);
		void Insert(CompanyDto entity);
		void Update(CompanyDto entity);
		void Delete(int id);
	}
}
