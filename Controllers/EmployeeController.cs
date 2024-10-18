using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.ServicesLayer.Contract;
using SimpleCompany.ServicesLayer.DTO.Department;
using SimpleCompany.ServicesLayer.DTO.Employee;

namespace SimpleCompany.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly IEmployeeService _employeeService;

		public EmployeeController(IEmployeeService _employeeService)
		{
			this._employeeService = _employeeService;
		}
		[HttpGet]
		public IActionResult GetAllEmplyees()
		{
			return Ok(_employeeService.GetAll());
		}
		[HttpGet("{id}")]
		public IActionResult GetDepartment(int id)
		{
			return Ok(_employeeService.GetById(id));
		}
		[HttpPost]
		public IActionResult AddDepartment(AddEmployeeDto e)
		{
			_employeeService.Insert(e);
			return Ok();

		}
		[HttpPut]
		public IActionResult updateDepartment(UpdateEmployee e)
		{
			
				_employeeService.Update(e);
				return Ok();
			
			//return NotFound();
		}
		[HttpDelete]
		public IActionResult DeleteDepartment(int id)
		{
			_employeeService.Delete(id);
			return Ok();
		}
	}
}
