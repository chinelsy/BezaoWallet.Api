using System;

namespace BezaoWallet.Entities.Dtos
{
    public class CustomerDto
    {
        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
    }
}
