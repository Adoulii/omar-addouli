using System.Linq.Expressions;

namespace TaskSystem.CoreApplication.Interfaces
{ 
    public interface IGenericRepository<TEntity> where TEntity : class
    {
      
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where );
        IEnumerable<TEntity> GetAll(); 
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }    
}