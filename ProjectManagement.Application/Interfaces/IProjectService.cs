using ProjectManagement.Application.DTOs.Projects;
using ProjectManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Application.Interfaces
{
    public interface IProjectService
    {
        Task<Project> CreateAsync(CreateProjectDto dto, Guid userId);
        Task<List<Project>> GetAllAsync(Guid userId);
        Task<Project?> GetByIdAsync(int id, Guid userId);
        Task<bool> UpdateAsync(int id, UpdateProjectDto dto, Guid userId);
        Task<bool> DeleteAsync(int id, Guid userId);
    }
}
