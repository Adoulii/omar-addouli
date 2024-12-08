
using Exam.CoreApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.CoreApplication.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    { 
          // here we use the dependency Injection to 
          // inject our unit of work and the repository into the service using constructor
         private readonly IGenericRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public Service(IUnitOfWork unitOfWork)
        {
            this._repository = unitOfWork.Repository<TEntity>();
            this._unitOfWork = unitOfWork;
        }
             
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public void Commit()
        {
            try
            {
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

