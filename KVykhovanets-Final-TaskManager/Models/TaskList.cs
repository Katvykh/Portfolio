using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KVykhovanets_Final_TaskManager.Models
{
    public class TaskList
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public bool UseDueDate { get; set; }
        public bool UseImportance { get; set; }

        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
