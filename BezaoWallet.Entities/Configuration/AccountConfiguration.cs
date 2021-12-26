using BezaoWallet.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BezaoWallet.Entities.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasData
                (
                new Account
                {
                    Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                    UserId = new Guid("1A986837-106B-4312-B045-8109166F457B"),
                    WalletId = "3071977856",
                    Balance = 1000000M,
                    AccountType = Enumerator.AccountType.Current,
                    IsActive = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now



                });
        }
    }
}
