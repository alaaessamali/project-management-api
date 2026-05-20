using ProjectManagement.Application.DTOs.Tasks;
using ProjectManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskStatus = ProjectManagement.Domain.Enums.TaskStatus;

namespace ProjectManagement.Application.Interfaces
{
    public interface ITaskService
    {
        Task<TaskItem> CreateAsync(CreateTaskDto dto);

        Task<List<TaskItem>> GetByProjectIdAsync(int projectId);

        Task<bool> UpdateStatusAsync(int id, TaskStatus status);

        Task<bool> DeleteAsync(int id);
    }
}
