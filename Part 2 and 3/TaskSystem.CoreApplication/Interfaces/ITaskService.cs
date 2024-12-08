using TaskSystem.CoreApplication.Domain;
using TaskSystem.CoreApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.CoreApplication.Interfaces
{

    // this interface is related to our Task Class Object, each Task class should implement this Interface 
    // to separate each services that should implemented by each classes and make our code modular
    public interface ITaskService:IService<Task>
    {

        public IList<Task> GetAllTasks();
        public IEnumerable<Task> getTasksByCategory();
        public void AddNewTask();
        public void DeleteTask();
        public void UpdateTask();

    }
}
