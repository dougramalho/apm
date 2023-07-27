using ApmDemonstracao.Core.DTOs;
using ApmDemonstracao.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Core.Services
{
    public interface IPolicyService
    {
        Task<IEnumerable<PolicyDTO>> GetAllAsync();
        Task<PolicyDTO> GetByIdAsync(int id);
        Task<PolicyDTO> AddAsync(PolicyDTO apolice);
        Task UpdateAsync(PolicyDTO apolice);
        Task DeleteAsync(int id);
    }
}
