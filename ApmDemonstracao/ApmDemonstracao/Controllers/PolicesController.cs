using ApmDemonstracao.Core.DTOs;
using ApmDemonstracao.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApmDemonstracao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicesController : ControllerBase
    {

        private readonly IPolicyService _policyService;

        public PolicesController(IPolicyService policyService)
        {
            _policyService = policyService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PolicyDTO>>> GetPolicies()
        {
            return new List<PolicyDTO>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PolicyDTO>> GetPolicy(int id)
        {
            return new PolicyDTO();
        }

        [HttpPost]
        public async Task<ActionResult<PolicyDTO>> PostPolicy(PolicyDTO apoliceDto)
        {
            return new PolicyDTO();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPolicy(int id, PolicyDTO apoliceDto)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePolicy(int id)
        {
            return Ok();
        }
    }
}
