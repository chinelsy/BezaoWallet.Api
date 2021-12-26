using BezaoWallet.Entities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BezaoWallet.Entities.Models
{
    public class Customer : IEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        [ForeignKey(nameof(Account))]
        public Guid AccountId { get; set; }
        public Account Account { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }
    }
}
