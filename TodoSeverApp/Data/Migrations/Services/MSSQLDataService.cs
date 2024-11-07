using Microsoft.EntityFrameworkCore;
using TodoSeverApp.Data.interfaces;

namespace TodoSeverApp.Data.Migrations.Services
{
    public class MSSQLDataService(ApplicationDbContext context) : IDataService
    {
        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            return await context.TaskItems.ToArrayAsync();
        }

        public async Task SaveAsync(TaskItem taskItem)
        {
            if (taskItem.Id == 0)
            {
                taskItem.CreatedDate = DateTime.Now;
                await context.TaskItems.AddAsync(taskItem);
            } 
            else
            {
                context.TaskItems.Update(taskItem);
            }
            await context.SaveChangesAsync();
        }

        public async Task<TaskItem> GetTaskAsync(int id)
        {
            return await context.TaskItems.FirstAsync(x => x.Id == id);
        }

        public async Task DeleteAsync(int id)
        {
            var taskItem = await context.TaskItems.FirstAsync(x => x.Id == id);
            context.TaskItems.Remove(taskItem);
            await context.SaveChangesAsync();
        }

        public async Task AddSubtaskAsync(int taskId, Subtask subtask)
        {
            var task = await context.TaskItems.Include(t => t.Subtasks).FirstOrDefaultAsync(t => t.Id == taskId);
            if (task != null)
            {
                task.Subtasks.Add(subtask);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteSubtaskAsync(int taskId, int subtaskId)
        {
            var task = await context.TaskItems.Include(t => t.Subtasks).FirstOrDefaultAsync(t => t.Id == taskId);
            if (task != null)
            {
                var subtask = task.Subtasks.FirstOrDefault(s => s.Id == subtaskId);
                if (subtask != null)
                {
                    task.Subtasks.Remove(subtask);
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task<IEnumerable<Subtask>> GetSubtasksAsync(int taskId)
        {
            var task = await context.TaskItems.Include(t => t.Subtasks).FirstOrDefaultAsync(t => t.Id == taskId);
            return task?.Subtasks ?? new List<Subtask>();
        }

    }
}
