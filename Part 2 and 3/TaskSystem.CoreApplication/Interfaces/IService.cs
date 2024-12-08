using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.CoreApplication.Interfaces
{

    // we used interface to store our services, whenever we want to ensure that we add a new service 
    // each class that implement this interface should be notified when a new service is added and should implement the new services
    // it is like a contract that contains the functions that each class should implement

    // this interface is generic interface that can be used by any class of our system
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where );
        void Commit();
    }
}
