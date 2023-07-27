using ApmDemonstracao.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Core.Repositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllAsync();
        Task<Client> GetByIdAsync(int id);
        Task<Client> AddAsync(Client cliente);
        Task UpdateAsync(Client cliente);
        Task DeleteAsync(int id);
    }
}
