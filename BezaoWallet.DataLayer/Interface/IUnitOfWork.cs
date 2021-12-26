using System.Threading.Tasks;

namespace BezaoWallet.DataLayer.Interface
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class;
        Task SaveChangesAsync();
    }

    public interface IUnitOfWork<TContext> : IUnitOfWork
    {

    }
}
