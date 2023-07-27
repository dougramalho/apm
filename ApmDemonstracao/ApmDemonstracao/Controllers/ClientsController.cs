using ApmDemonstracao.Core.DTOs;
using ApmDemonstracao.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApmDemonstracao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDTO>>> GetClients()
        {
            return new List<ClientDTO>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDTO>> GetClient(int id)
        {
            return new ClientDTO();
        }

        [HttpPost]
        public async Task<ActionResult<ClientDTO>> PostClient(ClientDTO clientDto)
        {
            return new ClientDTO();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(int id, ClientDTO clientDto)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            return Ok();
        }
    }
}
