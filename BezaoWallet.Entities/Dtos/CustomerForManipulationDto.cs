using System;
using System.ComponentModel.DataAnnotations;

namespace BezaoWallet.Entities.Dtos
{
    public abstract class CustomerForManipulationDto
    {
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "First Name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "DateOfBirth  cannot be empty")]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
    }
}
