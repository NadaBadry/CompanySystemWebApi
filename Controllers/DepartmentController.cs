using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.ServicesLayer.Contract;
using SimpleCompany.ServicesLayer.DTO.Department;

namespace SimpleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService _departmentService)
        {
            this._departmentService = _departmentService;
        }
        [HttpGet]
        public IActionResult GetAllDepartment()
        {
            return Ok(_departmentService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetDepartment(int id)
        {
            return Ok(_departmentService.GetById(id));
        }
        [HttpPost]
        public IActionResult AddDepartment(DeptDto dept)
        {
            _departmentService.Insert(dept);
			return Ok();

		}
        [HttpPut]
        public IActionResult updateDepartment(DeptDto dept)
        {
            _departmentService.Update(dept); 
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteDepartment(int id)
        {
            _departmentService.Delete(id);
            return Ok();
        }
    }
}
