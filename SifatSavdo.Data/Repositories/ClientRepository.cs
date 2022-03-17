using Microsoft.EntityFrameworkCore;
using SifatSavdo.Data.Contexts;
using SifatSavdo.Data.IRepositories;
using SifatSavdo.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifatSavdo.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        internal SifatSavdoDbContext dbContext;
        internal DbSet<Client> dbSet;
        public ClientRepository()
        {
            this.dbContext = dbContext = new SifatSavdoDbContext();
            this.dbSet = dbContext.Set<Client>();
        }
        
        public async void Create(Client client)
        {
            var entry = await dbSet.AddAsync(client);

            await dbContext.SaveChangesAsync();
        }
    }
}
