using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
    }
}
