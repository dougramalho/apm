using ApmDemonstracao.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Core.Services
{
    public interface IClaimService
    {
        Task<IEnumerable<ClaimDTO>> GetAllAsync();
        Task<ClaimDTO> GetByIdAsync(int id);
        Task<ClaimDTO> AddAsync(ClaimDTO reivindicacao);
        Task UpdateAsync(ClaimDTO reivindicacao);
    }
}
