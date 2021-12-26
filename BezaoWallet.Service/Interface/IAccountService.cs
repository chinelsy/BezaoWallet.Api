using BezaoWallet.Entities.Dtos;
using BezaoWallet.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BezaoWallet.Service.Interface
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccounts();
        Task<decimal> GetAccountBalance(string walletId);
        Task<AccountDto> GetByWalletId(string walletId);
        void CreateAccount(Account account);
        void DeleteAccount(Account account);
    }
}
