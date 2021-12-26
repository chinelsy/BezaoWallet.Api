using AutoMapper;
using BezaoWallet.DataLayer.Interface;
using BezaoWallet.Entities.Dtos;
using BezaoWallet.Entities.Models;
using BezaoWallet.Service.Helpers;
using BezaoWallet.Service.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BezaoWallet.Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceFactory _serviceFactory;
        private readonly IRepository<Customer> _customerRepo;
        public readonly IMapper _mapper;

        public CustomerService(IUnitOfWork unitOfWork, IServiceFactory serviceFactory, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _serviceFactory = serviceFactory;
            _customerRepo = unitOfWork.GetRepository<Customer>();
            _mapper = mapper;
        }

        public async Task<AccountDto> GetCustomerBywalletId(string walletId)
        {
            IAccountService accountService = _serviceFactory.GetServices<IAccountService>();
            var walletIdtDetail = await accountService.GetByWalletId(walletId);
            return walletIdtDetail;
        }

        public async Task<Customer> GetSingleCustomer(Guid id)
        {
            return await Task.FromResult(_customerRepo.GetSingleByCondition(x => x.Id == id));
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _customerRepo.GetAllAsync();
        }

        public async Task CreateCustomer(Guid userId)
        {

            var customer = new Customer
            {
                UserId = userId,

                Account = new Account()
                {
                    WalletId = WalletIdGenerator.GenerateWalletId(),
                    Balance = 0,
                    IsActive = true,
                    UserId = userId
                }
            };
            await _customerRepo.AddAsync(customer);
        }

       
        
    }
}
