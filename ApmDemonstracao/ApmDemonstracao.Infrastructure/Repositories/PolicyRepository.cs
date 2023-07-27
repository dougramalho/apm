using ApmDemonstracao.Core.Entities;
using ApmDemonstracao.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Infrastructure.Repositories
{
    public class PolicyRepository : IPolicyRepository
    {
        public Task<Policy> AddAsync(Policy apolice)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Policy>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Policy> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Policy apolice)
        {
            throw new NotImplementedException();
        }
    }
}
