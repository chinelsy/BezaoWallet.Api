using BezaoWallet.Entities.Enumerator;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BezaoWallet.Entities.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }

        [Column(TypeName = "decimal(38,2)")]
        public decimal Amount { get; set; }

        public Guid UserId { get; set; }

        [Column(TypeName = "decimal(38,2)")]
        public decimal AccountBalance { get; set; }

        public DateTime TimeStamp { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionMode TransactionMode { get; set; }
        public string SenderWalletId { get; set; }
        public string ReceiverWalledId { get; set; }

        [ForeignKey(nameof(Account))]
        public Guid AccountId { get; set; }
        public Account Account { get; set; } 

    }
}
