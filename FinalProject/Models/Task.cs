using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Models
{
    public class Task : ITask
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public Task(string description)
        {
            Description = description;
        }
    }
}
