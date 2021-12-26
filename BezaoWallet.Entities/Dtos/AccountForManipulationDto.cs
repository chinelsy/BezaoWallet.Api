using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BezaoWallet.Entities.Dtos
{
    public abstract class AccountForManipulationDto
    {
        [Required(ErrorMessage = "WalletId cannot be empty")]
        [MaxLength(10), MinLength(10)]
        public string WalletId { get; set; }

        [Column(TypeName = "decimal(38, 2)")]
        [DataType(DataType.Currency)]

        public decimal Balance { get; set; }

        public string AccountType { get; set; }
    }
}
