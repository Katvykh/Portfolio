using KVykhovanets_Final_TaskManager.Data;
using KVykhovanets_Final_TaskManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KVykhovanets_Final_TaskManager.Controllers
{
    public class TaskListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskListController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]//form to create new task list
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]//saves the new task list in the database
        public IActionResult Create(TaskList list)
        {
            if (ModelState.IsValid)
            {
                _context.TaskLists.Add(list);
                _context.SaveChanges();
                TempData["Success"] = "Task list created!";
                return RedirectToAction("Index", "Home");
            }
            return View(list);
        }

        [HttpGet]//show the tasks in the task list
        public IActionResult Details(int id)
        {
            var list = _context.TaskLists
                 .Include(l => l.Tasks)
                 .FirstOrDefault(l => l.Id == id);


            if (list == null)
            {
                return NotFound();
            }

            if (list.UseImportance || list.UseDueDate)
            {
                var orderedTasks = list.Tasks
                    .Where(t => !t.IsCompleted)
                    .OrderBy(t =>
                        list.UseImportance ? ImportanceValue(t.Importance) : 99)
                    .ThenBy(t =>
                        list.UseDueDate ? (t.DueDate ?? DateTime.MaxValue) : DateTime.MaxValue)
                    .ToList();

                var completedTasks = list.Tasks
                    .Where(t => t.IsCompleted)
                    .ToList();

                list.Tasks = orderedTasks.Concat(completedTasks).ToList();
            }
            else
            {
                //move completed tasks to the bottom
                list.Tasks = list.Tasks
                    .Where(t => !t.IsCompleted)
                    .Concat(list.Tasks.Where(t => t.IsCompleted))
                    .ToList();
            }

            return View(list);
        }

        //method that assigns numbers to easily sort tasks by importance
        private int ImportanceValue(string? importance)
        {
            return importance switch
            {
                "High" => 0,
                "Medium" => 1,
                "Low" => 2,
                _ => 99//completed tasks at the bottom of the list
            };
        }

        //deletes lists and tasks in it
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var list = _context.TaskLists.Include(l => l.Tasks).FirstOrDefault(l => l.Id == id);

            if (list == null)
            {
                return NotFound();
            }

            //Removes tasks in the list and then the list itself
            _context.Tasks.RemoveRange(list.Tasks);
            _context.TaskLists.Remove(list);
            _context.SaveChanges();

            TempData["Success"] = "Task list deleted!";
            return RedirectToAction("Index", "Home");
        }
    }
}
