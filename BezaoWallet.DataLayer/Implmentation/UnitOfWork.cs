using BezaoWallet.DataLayer.Interface;
using BezaoWallet.Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BezaoWallet.DataLayer.Implmentation
{
    public class UnitOfWork<TContext> : IUnitOfWork<BezaoWalletContext> where TContext : BezaoWalletContext
    {
        private Dictionary<Type, object> _repositories;
        private readonly TContext _context;
        public UnitOfWork(TContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IRepository<T> GetRepository<T>() where T : class
        {
            if (_repositories == null) _repositories = new Dictionary<Type, object>();

            var type = typeof(T);
            if (!_repositories.ContainsKey(type)) _repositories[type] = new Repository<T>(_context);
            return (IRepository<T>)_repositories[type];
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
