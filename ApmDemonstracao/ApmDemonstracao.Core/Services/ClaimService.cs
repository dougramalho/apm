using ApmDemonstracao.Core.DTOs;
using ApmDemonstracao.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Core.Services
{
    public class ClaimService : IClaimService
    {
        private readonly IClaimRepository _claimRepository;

        public ClaimService(IClaimRepository repository)
        {
            _claimRepository = repository;
        }

        public Task<ClaimDTO> AddAsync(ClaimDTO reivindicacao)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClaimDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ClaimDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ClaimDTO reivindicacao)
        {
            throw new NotImplementedException();
        }
    }
}
