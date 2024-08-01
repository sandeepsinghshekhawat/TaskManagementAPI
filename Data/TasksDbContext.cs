namespace TaskManagementAPI.Data
{
    using Microsoft.EntityFrameworkCore;
    using TaskManagementAPI.Models;
    public class TasksDbContext : DbContext
    {
        public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
    }
}
