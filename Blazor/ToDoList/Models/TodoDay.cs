namespace ToDoList.Models
{
    public class TodoDay : BaseEntity
    {
        public string Title { get; set; }
        public ICollection<TodoTask> Tasks { get; set; } = [];
    }
}
