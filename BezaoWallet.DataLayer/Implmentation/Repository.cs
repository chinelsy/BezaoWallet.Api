using BezaoWallet.DataLayer.Interface;
using BezaoWallet.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BezaoWallet.DataLayer.Implmentation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BezaoWalletContext _bezaoWalletContext;
        private readonly DbSet<T> _dbSet;
        public Repository(BezaoWalletContext bezaoWalletContext)
        {
            _bezaoWalletContext = bezaoWalletContext ?? throw new ArgumentException(nameof(bezaoWalletContext));
            _dbSet = _bezaoWalletContext.Set<T>();
        }

        public async Task<T> AddAsync(T obj)
        {
            await _bezaoWalletContext.SaveChangesAsync();
            return obj;
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();

        }

        public T GetSingleByCondition(Expression<Func<T, bool>> predicate = null, Func<IQueryable, IOrderedQueryable> orderby = null, params string[] includeProperties)
        {
            if (predicate is null) return _dbSet.ToList().FirstOrDefault();
            return _dbSet.Where(predicate).FirstOrDefault();
        }

        public T FindByCondition(Expression<Func<T, bool>> predicate = null, Func<IQueryable, IOrderedQueryable> orderby = null, params string[] includeProperties) =>

          _bezaoWalletContext.Set<T>().FirstOrDefault();

        public void Create(T entity) => _bezaoWalletContext.Set<T>().Add(entity);
        public void Update(T entity) => _bezaoWalletContext.Set<T>().Update(entity);
        public void Delete(T entity) => _bezaoWalletContext.Set<T>().Remove(entity);

        Task IRepository<T>.AddAsync(T obj)
        {
            throw new NotImplementedException();
        }
    }
}

