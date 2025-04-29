using KVykhovanets_Final_TaskManager.Data;
using KVykhovanets_Final_TaskManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace KVykhovanets_Final_TaskManager.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost]//create new task and assign to a list
        public IActionResult Create(TaskItem task)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("ModelState not valid");
            }

            var list = _context.TaskLists.FirstOrDefault(l => l.Id == task.TaskListId);
            if (list == null)
            {
                return NotFound("Task list not found.");
            }

            _context.Tasks.Add(task);
            _context.SaveChanges();


            return RedirectToAction("Details", "TaskList", new { id = task.TaskListId });
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            return View(); 
        }

        //mark task as completed
        [HttpPost]
        public IActionResult MarkComplete(int taskId)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == taskId);
            if (task == null) return NotFound();

            task.IsCompleted = true;
            _context.SaveChanges();

            return RedirectToAction("Details", "TaskList", new { id = task.TaskListId });
        }

        [HttpPost]//delete specific task
        public IActionResult Delete(int taskId)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == taskId);
            if (task == null) return NotFound();

            int listId = task.TaskListId;

            _context.Tasks.Remove(task);
            _context.SaveChanges();

            TempData["Success"] = "Task deleted!";
            return RedirectToAction("Details", "TaskList", new { id = listId });
        }
    }
}
