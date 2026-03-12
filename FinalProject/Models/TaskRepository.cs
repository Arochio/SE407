using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TaskRepository
    {
        public List<Task> Tasks { get; set; } = new List<Task>();
        public void Add(Task task)
        {
            Tasks.Add(task);
        }
        public void Remove(Task task)
        {
            Tasks.Remove(task);
        }
        public void Display()
        {
            int taskNumber = 1;
            foreach (Task task in Tasks)
            {
                Console.WriteLine($"Task {taskNumber}: {task.Description} (Completed: {task.IsCompleted})");
                taskNumber++;
            }
        }
    }
}
