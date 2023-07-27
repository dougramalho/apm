using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Core.Repositories
{
    public interface IClaimRepository
    {
        Task<IEnumerable<Claim>> GetAllAsync();
        Task<Claim> GetByIdAsync(int id);
        Task<Claim> AddAsync(Claim reivindicacao);
        Task UpdateAsync(Claim reivindicacao);
    }
}
