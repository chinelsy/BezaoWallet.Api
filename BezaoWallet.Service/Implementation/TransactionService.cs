using AutoMapper;
using BezaoWallet.DataLayer.Interface;
using BezaoWallet.Entities.Dtos;
using BezaoWallet.Entities.Models;
using BezaoWallet.Service.Interface;
using System;
using System.Threading.Tasks;


namespace BezaoWallet.Service.Implementation
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Transaction> _transactionRepo;
        private readonly IRepository<Account> _accountRepo;
        public readonly IMapper _mapper;
        public TransactionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _transactionRepo = unitOfWork.GetRepository<Transaction>();
            _accountRepo = unitOfWork.GetRepository<Account>();
            _mapper = mapper;


        }
        public async Task<decimal> Deposit(DepositeDto depositeDto)
        {
            var wallet = _accountRepo.FindByCondition(d => d.WalletId == depositeDto.WalletId);
            if (wallet == null)
            {
                throw new Exception("Wallet Account can not be empty, please put your walletId");
            }

            if (!wallet.IsActive)
            {
                throw new Exception("Your walletId is inactive visit the Admin");
            }

            if (depositeDto.Amount <= 0)
            {
                throw new Exception("you cannot Deposit below 0 Amount");
            }

            else
            {
                wallet.Balance += depositeDto.Amount;
            }

            var deposit = new Transaction()
            {
                Amount = depositeDto.Amount,
                TimeStamp = DateTime.Now,
                TransactionMode = Entities.Enumerator.TransactionMode.Deposit,
                TransactionType = Entities.Enumerator.TransactionType.Credit,
                ReceiverWalledId = wallet.WalletId,
                UserId = wallet.UserId
            };
            await _transactionRepo.AddAsync(deposit);
            await _unitOfWork.SaveChangesAsync();
            return deposit.AccountBalance;
        }

        public async Task<bool> Transfer(TransactionDto transactionDto)
        {
            var senderWallet = _accountRepo.FindByCondition(w => w.WalletId == transactionDto.SenderWalletId);
            if (senderWallet == null)
            {
                throw new Exception("Sender WalletId not found or invalid walletId");
            }

            var receiverWallet = _accountRepo.FindByCondition(w => w.WalletId == transactionDto.ReceiverWalledId);
            if (receiverWallet == null)
            {
                throw new Exception("Receiver WalletId not found or invalid walletId");
            }

            if (receiverWallet == senderWallet)
            {
                throw new Exception("You cannot Transfer to your own Wallet Account");
            }

            if (transactionDto.Amount <= 0)
            {
                throw new Exception("You cannot Transfer 0 Amount");
            }

            if (transactionDto.Amount > 1000000)
            {
                throw new Exception("You cannot Transfer above your daily limit of 1,000,000");
            }

            if (transactionDto.Amount >= (senderWallet.Balance - 1000))
            {
                throw new Exception("You cannot Transfer above your Wallet Balance");
            }
            senderWallet.Balance -= transactionDto.Amount;
            receiverWallet.Balance += transactionDto.Amount;

            var transferSender = new Transaction
            {
                Amount = transactionDto.Amount,
                TimeStamp = DateTime.Now,
                TransactionMode = Entities.Enumerator.TransactionMode.Transfer,
                TransactionType = Entities.Enumerator.TransactionType.Debit,
                SenderWalletId = senderWallet.WalletId,
                UserId = senderWallet.UserId
            };

            var transferReceiver = new Transaction
            {
                Amount = transactionDto.Amount,
                TimeStamp = DateTime.Now,
                TransactionMode = Entities.Enumerator.TransactionMode.Transfer,
                TransactionType = Entities.Enumerator.TransactionType.Credit,
                ReceiverWalledId = receiverWallet.WalletId,
                UserId = receiverWallet.UserId
            };

            await _transactionRepo.AddAsync(transferReceiver);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<decimal> Withdraw(WithdrawalDto withdrawalDto)
        {
            var wallet = _accountRepo.FindByCondition(w => w.WalletId == withdrawalDto.WalletId);

            if (wallet == null)
            {
                throw new Exception("Wallet Accout not found");
            }

            if (!wallet.IsActive)
            {
                throw new Exception("Inactive Account, visit the Admin for Account Re-Activation");
            }

            if (withdrawalDto.Amount <= 1000)
            {
                throw new Exception("Insufficient balance");
            }

            if (withdrawalDto.Amount > 500000)
            {
                throw new Exception("You cannot Withdraw above your daily limit of 500,000");
            }

            if (withdrawalDto.Amount >= (wallet.Balance - 1000))
            {
                throw new Exception("You cannot Withdraw above your Wallet Balance");
            }

            wallet.Balance -= withdrawalDto.Amount;

            var withdraw = new Transaction()
            {
                Amount = withdrawalDto.Amount,
                TimeStamp = DateTime.Now,
                TransactionMode = Entities.Enumerator.TransactionMode.Withdraw,
                TransactionType = Entities.Enumerator.TransactionType.Debit,
                ReceiverWalledId = wallet.WalletId,
                UserId = wallet.UserId
            };
            await _transactionRepo.AddAsync(withdraw);
            await _unitOfWork.SaveChangesAsync();
            return withdraw.AccountBalance;
        }

    }
}



