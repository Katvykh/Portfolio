using System;


namespace KVykhovanets_Final_TaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Importance { get; set; }
        public bool IsCompleted { get; set; }

        // Foreign key
        public int TaskListId { get; set; }
        public TaskList TaskList { get; set; }
    }
}
