namespace TaskSystem.CoreApplication.Domain
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority  {get; set;}

        public DateTime DueDate { get; set; }
        // For easily managing task category we separate
        // task category to a new class object for better scalability of the app
        public Category TaskCategory {get;set;}

        public Status TaskStatus {get;set;}


    }
}