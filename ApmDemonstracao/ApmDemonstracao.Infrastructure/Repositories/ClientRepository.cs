using ApmDemonstracao.Core.Entities;
using ApmDemonstracao.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Task<Client> AddAsync(Client cliente)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Client>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Client cliente)
        {
            throw new NotImplementedException();
        }
    }
}
