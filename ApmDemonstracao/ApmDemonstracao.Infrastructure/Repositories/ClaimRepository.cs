using ApmDemonstracao.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Infrastructure.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        public Task<Claim> AddAsync(Claim reivindicacao)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Claim>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Claim> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Claim reivindicacao)
        {
            throw new NotImplementedException();
        }
    }
}
