using BezaoWallet.Entities.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Transactions;

namespace BezaoWallet.Service.Interface
{
    public interface ITransactionService
    {
        Task<bool> Transfer(TransactionDto transactionDto);
        Task<decimal> Withdraw(WithdrawalDto withdrawalDto);
        Task<decimal> Deposit(DepositeDto depositeDto);
    }
}
