using System.ComponentModel.DataAnnotations;

namespace BezaoWallet.Entities.Dtos
{
    public class TransactionDto
    {
        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string SenderWalletId { get; set; }

        [Required]
        public string ReceiverWalledId { get; set; }

        [Required]
        public string TransactionType { get; set; }

        [Required]
        public string TransactionMode { get; set; }

        [Required]
        public System.DateTime TimeStamp { get; set; }
    }
}
