
using TaskSystem.CoreApplication.Domain;
using TaskSystem.CoreApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaskSystem.CoreApplication.Services
{
    public class TaskService : Service<Task>, ITaskService
    {
        // we inject our unitOfWork class
           public TaskService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<IGrouping<TaskCategory, Task>> getTasksByCategory(){
            return GetAll().OrderBy((t) => t.DueDate).GroupBy((t) => t.TaskCategory);
        }
            public IEnumerable<IGrouping<Status, Task>> getTasksByStatus(){
            return GetAll().OrderBy((t) => t.DueDate).GroupBy((t) => t.Status);

        }

        public List<Task> GetAllTasks(){
            return GetAll().OrderBy((t) => t.DueDate);
        }

        public void AddNewTask(Task t){
            return Add(t);
        }

        public void DeleteTask(Task t){
            return Delete(t)
        }
        public void UpdateTask(Task t){
            return Update(t);
        }


    }}