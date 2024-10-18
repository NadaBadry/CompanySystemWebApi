using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.DataAccessLayer.Repository;
using SimpleCompany.DataAccessLayer.Repository.Contract;
using SimpleCompany.ServicesLayer.Contract;
using SimpleCompany.ServicesLayer.DTO.InsuranceCompany;
using SimpleCompany.ServicesLayer.DTO.Project;

namespace SimpleCompany.ServicesLayer
{
	public class InsuranceCompanyService : IInsuranceCompanyService
	{
		private readonly IInsuranceCompanyRepository insuranceCompanyRepository;
        public InsuranceCompanyService(IInsuranceCompanyRepository _insuranceCompanyRepository)
        {
			insuranceCompanyRepository = _insuranceCompanyRepository;
		}
        public IEnumerable<CompanyDto> GetAll()
		{
			return insuranceCompanyRepository.GetAll().Select(p => new CompanyDto
			{
				Id = p.Id,
				Name = p.Name

			});
		}

		public CompanyDto GetById(int id)
		{
			var company = insuranceCompanyRepository.GetById(id);
			if (company != null)
			{
				return new CompanyDto
				{
					Id= company.Id,	
					Name = company.Name
				};
			}
			return null;
		}

		public void Insert(CompanyDto entity)
		{
			var company = new InsuranceCompany
			{
			
				Id = entity.Id,
				Name=entity.Name
			};
			insuranceCompanyRepository.Insert(company);
			insuranceCompanyRepository.save();
		}

		public void Update(CompanyDto entity)
		{
			var company = new InsuranceCompany
			{
				Id= entity.Id,
				Name= entity.Name
			};
			insuranceCompanyRepository.Update(company);
			insuranceCompanyRepository.save();
		}

		public void Delete(int id)
		{
			insuranceCompanyRepository.Delete(id);
			insuranceCompanyRepository.save();
		}

	}
}
