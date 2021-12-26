using System;
using System.ComponentModel.DataAnnotations;

namespace BezaoWallet.Entities.Models
{
    public class Admin
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

