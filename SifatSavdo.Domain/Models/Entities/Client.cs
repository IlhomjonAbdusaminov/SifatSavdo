using SifatSavdo.Domain.Commons;
using SifatSavdo.Domain.Enums;
using System;

namespace SifatSavdo.Domain.Models.Entities
{
    public class Client : IAuditable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; } = null;

        public Guid? UpdatedBy { get; set; } = null;

        public ItemState State { get; set; } = ItemState.Created;
    }
}
