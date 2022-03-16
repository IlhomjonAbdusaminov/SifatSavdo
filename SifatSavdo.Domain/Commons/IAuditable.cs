using SifatSavdo.Domain.Enums;
using System;

namespace SifatSavdo.Domain.Commons
{
    public interface IAuditable
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        int? UpdatedBy { get; set; }
        ItemState State { get; set; }
    }
}
