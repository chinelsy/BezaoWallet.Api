using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BezaoWallet.Entities.Dtos
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "First Name cannot be empty")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name cannot be empty")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<string> Roles { get; set; }
    }
}
