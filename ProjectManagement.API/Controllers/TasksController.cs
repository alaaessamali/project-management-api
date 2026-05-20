using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Application.DTOs.Tasks;
using ProjectManagement.Application.Interfaces;

namespace ProjectManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

       
        [HttpPost]
        public async Task<IActionResult> Create(CreateTaskDto dto)
        {
            var result = await _taskService.CreateAsync(dto);
            return Ok(result);
        }

       
        [HttpGet("project/{projectId}")]
        public async Task<IActionResult> GetByProject(int projectId)
        {
            var result = await _taskService.GetByProjectIdAsync(projectId);
            return Ok(result);
        }

      
        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateStatus(int id, UpdateTaskStatusDto dto)
        {
            var result = await _taskService.UpdateStatusAsync(id, dto.Status);

            if (!result)
                return NotFound("Task not found");

            return Ok("Status updated successfully");
        }

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _taskService.DeleteAsync(id);

            if (!result)
                return NotFound("Task not found");

            return Ok("Deleted successfully");
        }
    }
}
