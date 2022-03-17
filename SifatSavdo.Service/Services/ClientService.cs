using Microsoft.EntityFrameworkCore.ChangeTracking;
using SifatSavdo.Data.Repositories;
using SifatSavdo.Domain.Enums;
using SifatSavdo.Domain.Models.Entities;
using SifatSavdo.Service.Interfaces;
using SifatSavdo.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SifatSavdo.Service.Services
{
    public class ClientService : IClientService
    {
        private ClientRepository _clientRepository;
        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }

        public Task<Client> CreateAsync(ClientViewModel model)
        {
            Client client = new Client
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                Login = model.Login,
                Password = model.Password
            };

            return _clientRepository.CreateAsync(client);
        }

        public Task<IEnumerable<Client>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Client, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetAsync(Expression<Func<Client, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Client> UpdateAsync(Client model)
        {
            throw new NotImplementedException();
        }

        public Task<Client> UpdateStatusAsync(long id, ItemState state)
        {
            throw new NotImplementedException();
        }
    }
}
