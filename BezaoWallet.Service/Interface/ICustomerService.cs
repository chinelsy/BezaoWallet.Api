using BezaoWallet.Entities.Dtos;
using BezaoWallet.Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BezaoWallet.Service.Interface
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<Customer> GetSingleCustomer(Guid id);
        Task<AccountDto> GetCustomerBywalletId(string walletId);
        Task CreateCustomer(Guid userId);
        
    }
}
 