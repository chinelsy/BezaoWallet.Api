
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BezaoWallet.Entities.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "First Name cannot be empty")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name cannot be empty")]
        public string LastName { get; set; }
    }
}
