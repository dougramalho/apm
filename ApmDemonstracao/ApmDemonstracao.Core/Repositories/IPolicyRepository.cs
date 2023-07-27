using ApmDemonstracao.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Core.Repositories
{
    public interface IPolicyRepository
    {
        Task<IEnumerable<Policy>> GetAllAsync();
        Task<Policy> GetByIdAsync(int id);
        Task<Policy> AddAsync(Policy apolice);
        Task UpdateAsync(Policy apolice);
        Task DeleteAsync(int id);
    }
}
