using System.ComponentModel.DataAnnotations;

namespace TodoSeverApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public List<Subtask> Subtasks { get; set; } = new();
    }
}
