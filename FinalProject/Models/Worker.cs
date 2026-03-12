using Interfaces;

namespace Models
{
    public class Worker : IWorker
    {
        public Task Task { get; set; }
        public void CompleteTask()
        {
            Task.IsCompleted = true;
        }
        public Worker(Task task)
        {
            Task = task;
        }
    }
}
