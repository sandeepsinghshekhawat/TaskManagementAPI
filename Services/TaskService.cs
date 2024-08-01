
namespace TaskManagementAPI.Services
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using TaskManagementAPI.Data;
    using Task = Models.Task;
    public class TaskService : ITaskService
    {
        private readonly TasksDbContext _context;

        public TaskService(TasksDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// It returns the list of tasks saved in DB table
        /// </summary>
        /// <returns> List Of Tasks </returns>
        public async System.Threading.Tasks.Task<IEnumerable<Task>> GetTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        /// <summary>
        /// It returns the particular task with id given in argument
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task</returns>
        public async System.Threading.Tasks.Task<Task> GetTaskByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        /// <summary>
        /// It Adds/Saves the task with given object
        /// </summary>
        /// <param name="task"></param>
        /// <returns>Saved Task</returns>
        public async System.Threading.Tasks.Task<Task> AddTaskAsync(Task task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        /// <summary>
        /// It deletes the task with given id in argument
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Boolean value for weather task is deleted or not</returns>
        public async System.Threading.Tasks.Task<bool> DeleteTaskAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return false;
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
