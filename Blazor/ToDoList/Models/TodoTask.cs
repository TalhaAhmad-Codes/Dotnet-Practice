namespace ToDoList.Models
{
    public class TodoTask : BaseEntity
    {
        public string Task { get; set; }
        public bool IsCompleted { get; set; }

        public Guid TodoDayId { get; set; }
        public TodoDay TodoDay { get; set; }
    }
}
