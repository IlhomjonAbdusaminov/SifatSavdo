using SifatSavdo.Domain.Commons;
using SifatSavdo.Domain.Enums;
using System;

namespace SifatSavdo.Domain.Models.Entities
{
    public class Client : IAuditable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedBy { get; set; }

        public ItemState State { get; set; }
    }
}
