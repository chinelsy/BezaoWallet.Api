
using AutoMapper;
using BezaoWallet.DataLayer.Interface;
using BezaoWallet.Entities.Dtos;
using BezaoWallet.Entities.Models;
using BezaoWallet.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BezaoWallet.Service.Implementation
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Account> _accountRepo;
        private readonly IMapper _mapper;
        public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _accountRepo = unitOfWork.GetRepository<Account>();
            _mapper = mapper;
        }

        public void CreateAccount(Account account)
        {
            _accountRepo.Create(account);
        }

        public void DeleteAccount(Account account)
        {
            _accountRepo.Delete(account);
        }

        public async Task<decimal> GetAccountBalance(string walletId)
        {
            var wallet = await Task.FromResult(_accountRepo.FindByCondition(w => w.WalletId == walletId));
            if (wallet == null)
            {
                return 0;
            }
            else
            {
                return wallet.Balance;
            }
        }

        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await _accountRepo.GetAllAsync();
        }

        public async Task<AccountDto> GetByWalletId(string walletId)
        {
            Account customerAccount = _accountRepo.FindByCondition(w => w.WalletId == walletId, includeProperties: "Customers");
            return _mapper.Map<AccountDto>(customerAccount);
        }
    }
}
