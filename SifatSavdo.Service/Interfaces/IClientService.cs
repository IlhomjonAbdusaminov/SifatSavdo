using Microsoft.EntityFrameworkCore.ChangeTracking;
using SifatSavdo.Domain.Enums;
using SifatSavdo.Domain.Models.Entities;
using SifatSavdo.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SifatSavdo.Service.Interfaces
{
    public interface IClientService
    {
        Task<Client> CreateAsync(ClientViewModel model);
        Task<Client> GetAsync(Expression<Func<Client, bool>> predicate);
        Task<IEnumerable<Client>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Client, bool>> predicate = null);
        Task<Client> UpdateAsync(Client model);
        Task<Client> UpdateStatusAsync(long id, ItemState state);
    }
}
