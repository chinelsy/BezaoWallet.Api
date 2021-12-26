using BezaoWallet.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BezaoWallet.Entities.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData
             (
                new Customer
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    UserId = new Guid("1A986837-106B-4312-B045-8109166F457B"),
                    DateOfBirth = new DateTime(1995, 07, 27),
                    Address = "United State Of Abakpa",
                    AccountId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a")
                });
        }
    }
}
