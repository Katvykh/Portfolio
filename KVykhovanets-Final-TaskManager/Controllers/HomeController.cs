using Azure.Identity;
using KVykhovanets_Final_TaskManager.Data;
using KVykhovanets_Final_TaskManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace KVykhovanets_Final_TaskManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var lists = _context.TaskLists.ToList();
            return View(lists);
        }

    }
}
