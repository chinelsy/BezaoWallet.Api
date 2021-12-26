using BezaoWallet.Entities.Enumerator;
using BezaoWallet.Entities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BezaoWallet.Entities.Models
{
    public class Account : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(10), MinLength(10)]
        public string WalletId { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public AccountType AccountType { get; set; }
        public bool IsActive { get; set; } 
        public Guid UserId { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }
    }
}
