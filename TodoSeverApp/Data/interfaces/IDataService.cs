namespace TodoSeverApp.Data.interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task SaveAsync(TaskItem item);
        Task<TaskItem> GetTaskAsync(int id);
        Task DeleteAsync(int id);
        Task AddSubtaskAsync(int taskId, Subtask subtask);
        Task DeleteSubtaskAsync(int taskId, int subtaskId);
        Task<IEnumerable<Subtask>> GetSubtasksAsync(int taskId);
    }
}
