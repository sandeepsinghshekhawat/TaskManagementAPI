namespace TaskManagementAPI.Services
{
    using Task = Models.Task;

    public interface ITaskService
    {
        /// <summary>
        /// It returns the list of tasks saved in DB table
        /// </summary>
        /// <returns> List Of Tasks </returns>
        Task<IEnumerable<Task>> GetTasksAsync();

        /// <summary>
        /// It returns the particular task with id given in argument
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Task</returns>
        Task<Task> GetTaskByIdAsync(int id);

        /// <summary>
        /// It Adds/Saves the task with given object
        /// </summary>
        /// <param name="task"></param>
        /// <returns>Saved Task</returns>
        Task<Task> AddTaskAsync(Task task);

        /// <summary>
        /// It deletes the task with given id in argument
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Boolean value for weather task is deleted or not</returns>
        Task<bool> DeleteTaskAsync(int id);
    }
}
