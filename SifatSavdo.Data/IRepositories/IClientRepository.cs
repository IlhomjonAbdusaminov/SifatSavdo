using SifatSavdo.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifatSavdo.Data.IRepositories
{
    public interface IClientRepository
    {
        void Create(Client client);
    }
}
