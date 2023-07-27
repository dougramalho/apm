using ApmDemonstracao.Core.DTOs;
using ApmDemonstracao.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Core.Services
{
    public class PolicyService : IPolicyService
    {
        private readonly IPolicyRepository _policyRepository;

        public PolicyService(IPolicyRepository repository)
        {
            _policyRepository = repository;
        }

        public Task<PolicyDTO> AddAsync(PolicyDTO apolice)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PolicyDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PolicyDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PolicyDTO apolice)
        {
            throw new NotImplementedException();
        }
    }
}
