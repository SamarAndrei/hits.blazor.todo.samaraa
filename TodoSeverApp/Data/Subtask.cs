using System.ComponentModel.DataAnnotations;

namespace TodoSeverApp.Data
{
    public class Subtask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public int TaskItemId { get; set; }
    }

}