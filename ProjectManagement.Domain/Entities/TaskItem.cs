using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Domain.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Status { get; set; } = "ToDo";

        public DateTime DueDate { get; set; }

        public string Priority { get; set; } = "Medium";

       
        public Guid ProjectId { get; set; }

       
        public Project Project { get; set; } = null!;
    }
}
