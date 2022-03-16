using Microsoft.EntityFrameworkCore;
using SifatSavdo.Domain.Commons;
using SifatSavdo.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifatSavdo.Data.Contexts
{
    public class SifatSavdoDbContext : DbContext
    {
        public virtual DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer(Constants.CONNECTION_STRING);
        }
    }
}
