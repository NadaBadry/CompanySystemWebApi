using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCompany.ServicesLayer.Contract;
using SimpleCompany.ServicesLayer.DTO.InsuranceCompany;

namespace SimpleCompany.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class IncuranceCompanyController : ControllerBase
	{
		private readonly IInsuranceCompanyService _insuranceCompanyService;
        public IncuranceCompanyController(IInsuranceCompanyService _insuranceCompanyService)
        {
            this._insuranceCompanyService= _insuranceCompanyService;

		}
		[HttpGet]
		public ActionResult Get()
		{
			return Ok(_insuranceCompanyService.GetAll());
		}
		[HttpGet("{id}")]
		public ActionResult GetIC(int id)
		{
			return Ok(_insuranceCompanyService.GetById(id));
		
		}
		[HttpPost]
		public ActionResult AddNewIC(CompanyDto ic)
		{
			_insuranceCompanyService.Insert(ic);
			return Ok();
		}
		[HttpPut]
		public ActionResult UpdateIC(CompanyDto ic)
		{
			_insuranceCompanyService.Update(ic);
			return Ok();
		}
		[HttpDelete]
		public ActionResult DeleteIC(int id)
		{
			_insuranceCompanyService.Delete(id);
			return Ok();
		}
	}
}
