using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KVykhovanets_Final_TaskManager.Models;

namespace KVykhovanets_Final_TaskManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TaskList> TaskLists { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
    }
}
