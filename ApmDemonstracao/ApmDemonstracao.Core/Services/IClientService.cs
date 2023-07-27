using ApmDemonstracao.Core.DTOs;
using ApmDemonstracao.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Core.Services
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDTO>> GetAllAsync();
        Task<ClientDTO> GetByIdAsync(int id);
        Task<ClientDTO> AddAsync(ClientDTO cliente);
        Task UpdateAsync(ClientDTO cliente);
        Task DeleteAsync(int id);
    }
}
