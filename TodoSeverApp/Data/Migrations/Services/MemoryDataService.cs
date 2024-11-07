using TodoSeverApp.Components.Pages;
using TodoSeverApp.Data.interfaces;

namespace TodoSeverApp.Data.Migrations.Services
{
    public class MemoryDataService : IDataService
    {

        private static IEnumerable<TaskItem> _tasks = new List<TaskItem> {
            new() {Id = 1, Title="Заголовок 1", Description="Описание 1", CreatedDate=DateTime.Now, FinishedDate=DateTime.Now },
            new() {Id = 2, Title="Заголовок 2", Description="Описание 2", CreatedDate=DateTime.Now, FinishedDate=DateTime.Now },
            new() {Id = 3, Title="Заголовок 3", Description="Описание 3", CreatedDate=DateTime.Now, FinishedDate=DateTime.Now }
        };

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task <IEnumerable<TaskItem>> GetAllAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(_tasks);
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(TaskItem item)
        {
            throw new NotImplementedException();
        }

        public async Task AddSubtaskAsync(int taskId, Subtask subtask)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                subtask.Id = task.Subtasks.Count > 0 ? task.Subtasks.Max(s => s.Id) + 1 : 1;
                task.Subtasks.Add(subtask);
            }
            await Task.CompletedTask;
        }

        public async Task DeleteSubtaskAsync(int taskId, int subtaskId)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                var subtask = task.Subtasks.FirstOrDefault(s => s.Id == subtaskId);
                if (subtask != null)
                {
                    task.Subtasks.Remove(subtask);
                }
            }
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Subtask>> GetSubtasksAsync(int taskId)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            return task != null ? task.Subtasks : new List<Subtask>();
        }
    }
}
