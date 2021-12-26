namespace BezaoWallet.Service.Interface
{
    public interface IServiceFactory
    {
        T GetServices<T>() where T : class;
    }
}
