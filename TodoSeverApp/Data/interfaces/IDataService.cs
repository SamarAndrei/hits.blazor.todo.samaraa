namespace TodoSeverApp.Data.interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItem>> GetTasksAsync();
    }
}
