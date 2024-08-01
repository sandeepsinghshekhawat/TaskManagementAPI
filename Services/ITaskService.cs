namespace TaskManagementAPI.Services
{
    using Task = Models.Task;

    public interface ITaskService
    {
        Task<IEnumerable<Task>> GetTasksAsync();
        Task<Task> GetTaskByIdAsync(int id);
        Task<Task> AddTaskAsync(Task task);
        Task<bool> DeleteTaskAsync(int id);
    }
}
