using System.ComponentModel.DataAnnotations;

namespace BezaoWallet.Entities.Dtos
{
    public class WithdrawalDto
    {
        public decimal Amount { get; set; }

        [Display(Name = "Wallet Account")]
        public string WalletId { get; set; }
    }
}
