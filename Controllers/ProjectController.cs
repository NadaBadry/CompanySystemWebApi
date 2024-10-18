using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleCompany.DataAccessLayer.Model;
using SimpleCompany.ServicesLayer.Contract;
using SimpleCompany.ServicesLayer.DTO.Project;
using System.Reflection.Metadata.Ecma335;

namespace SimpleCompany.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProjectController : ControllerBase
	{
		private readonly IProjectService projectService;
        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }
		[HttpGet]
		public IActionResult GetAllProjects()
		{
			return Ok(projectService.GetAll());
		}
		[HttpGet("{id}")]
		public IActionResult GetProject(int id)
		{
			return Ok(projectService.GetById(id));

		}
		[HttpPost]
		public IActionResult AddProjectDetails(ProjectDto p)
		{
			projectService.Insert(p);
			return Ok();
		}
		[HttpPut]
		public IActionResult updateProject(ProjectDto p)
		{
			projectService.Update(p);
			return Ok();
		}
		[HttpDelete]
		public IActionResult DeleteProject(int id)
		{
			projectService.Delete(id);
			return Ok();
		}
    }
}
