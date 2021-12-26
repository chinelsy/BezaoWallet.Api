using System;

namespace BezaoWallet.Entities.Dtos
{
    public class AccountDto
    {
        public Guid Id { get; set; }
        public string WalletId { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
    }
}
