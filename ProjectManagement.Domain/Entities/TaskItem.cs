using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagement.Domain.Enums;
using TaskStatus = ProjectManagement.Domain.Enums.TaskStatus;
namespace ProjectManagement.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;


        public TaskStatus Status { get; set; } = TaskStatus.ToDo;

        public DateTime DueDate { get; set; }

        public string Priority { get; set; } = "Medium";

       
        public int ProjectId { get; set; }

       
        public Project Project { get; set; } = null!;
    }
}
