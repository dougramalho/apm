using ApmDemonstracao.Core.DTOs;
using ApmDemonstracao.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Core.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository repository)
        {
            _clientRepository = repository;
        }

        public Task<ClientDTO> AddAsync(ClientDTO cliente)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ClientDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ClientDTO cliente)
        {
            throw new NotImplementedException();
        }
    }
}
