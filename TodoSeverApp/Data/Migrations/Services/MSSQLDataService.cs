using Microsoft.EntityFrameworkCore;
using TodoSeverApp.Data.interfaces;

namespace TodoSeverApp.Data.Migrations.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<TaskItem>> GetTasksAsync()
        {
            return await context.TaskItems.ToArrayAsync();
        }
    }
}
