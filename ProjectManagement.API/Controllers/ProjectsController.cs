using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Application.DTOs.Projects;
using ProjectManagement.Application.Interfaces;
using System.Security.Claims;

namespace ProjectManagement.API.Controllers
{
  //  [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _service;

        public ProjectsController(IProjectService service)
        {
            _service = service;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateProjectDto dto)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var project = await _service.CreateAsync(dto, Guid.Parse(userId!));

            return Ok(project);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var projects = await _service.GetAllAsync(Guid.Parse(userId!));

            return Ok(projects);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var project = await _service.GetByIdAsync(id, Guid.Parse(userId!));

            if (project == null)
                return NotFound();

            return Ok(project);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateProjectDto dto)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var result = await _service.UpdateAsync(id, dto, Guid.Parse(userId!));

            if (!result)
                return NotFound();

            return Ok("Updated successfully");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var result = await _service.DeleteAsync(id, Guid.Parse(userId!));

            if (!result)
                return NotFound();

            return Ok("Deleted successfully");
        }
    }
}
