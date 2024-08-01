namespace TaskManagementAPI.Tests
{
    using Microsoft.EntityFrameworkCore;
    using TaskManagementAPI.Data;
    using TaskManagementAPI.Models;
    using TaskManagementAPI.Services;
    using Xunit;

    public class TaskServiceTests
    {
        private readonly TasksDbContext _context;
        private readonly TaskService _service;

        public TaskServiceTests()
        {
            var options = new DbContextOptionsBuilder<TasksDbContext>()
                .UseInMemoryDatabase(databaseName: "TaskDb")
                .Options;

            _context = new TasksDbContext(options);
            _service = new TaskService(_context);
        }

        [Fact]
        public async System.Threading.Tasks.Task AddTaskAsync_ShouldAddTask()
        {
            var task = new Task { Description = "Test Task" };

            var result = await _service.AddTaskAsync(task);

            Assert.NotNull(result);
            Assert.Equal("Test Task", result.Description);
        }

        [Fact]
        public async System.Threading.Tasks.Task GetTasksAsync_ShouldReturnTasks()
        {
            var tasks = await _service.GetTasksAsync();

            Assert.NotNull(tasks);
        }

        [Fact]
        public async System.Threading.Tasks.Task GetTaskByIdAsync_ShouldReturnTask()
        {
            var task = new Task { Description = "Test Task" };
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();

            var result = await _service.GetTaskByIdAsync(task.Id);

            Assert.NotNull(result);
            Assert.Equal("Test Task", result.Description);
        }

        [Fact]
        public async System.Threading.Tasks.Task DeleteTaskAsync_ShouldDeleteTask()
        {
            var task = new Task { Description = "Test Task" };
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();

            var result = await _service.DeleteTaskAsync(task.Id);

            Assert.True(result);
        }
    }
}
