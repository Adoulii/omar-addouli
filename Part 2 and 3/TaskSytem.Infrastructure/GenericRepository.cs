﻿using Exam.CoreApplication.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Exam.Infrastructure
{

       // we used generic repository that will handle CRUD Operations for different 
    // task system management operations 
    
    // we inject the DbContext so, we inject the dbcontext to minimise the database connection calls each time we access to our db

    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        private readonly IUnitOfWork _unitOfWork;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        
        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsEnumerable();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> where)
        {
            _dbSet.RemoveRange(_dbSet.Where(where));
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return _dbSet.Where(where).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where )
        {
            IQueryable<TEntity> mydbset = _dbSet;
            if (where != null)
                mydbset = mydbset.Where(where);
            return mydbset.AsEnumerable();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public void SubmitChanges()
        {
            _unitOfWork.Save();
        }
    }
}