using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TaskStatus = ProjectManagement.Domain.Enums.TaskStatus;
namespace ProjectManagement.Application.DTOs.Tasks
{
    public class UpdateTaskStatusDto
    {
        public TaskStatus Status { get; set; } 
    }
}
