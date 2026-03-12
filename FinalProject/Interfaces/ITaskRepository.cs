using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITaskRepository
    {
        public void Add(ITask task);
        public void Remove(ITask task);
        public string Display();
    }
}
