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
        public async Task <IEnumerable<TaskItem>> GetTasksAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(_tasks);
        }
    }
}
