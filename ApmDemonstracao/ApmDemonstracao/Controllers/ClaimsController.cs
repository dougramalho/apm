using ApmDemonstracao.Core.DTOs;
using ApmDemonstracao.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApmDemonstracao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly IClaimService _claimService;

        public ClaimsController(IClaimService claimService)
        {
            _claimService = claimService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClaimDTO>>> GetReivindicacoes()
        {
            return new List<ClaimDTO>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClaimDTO>> GetReivindicacao(int id)
        {
            return new ClaimDTO();
        }

        [HttpPost]
        public async Task<ActionResult<ClaimDTO>> PostReivindicacao(ClaimDTO reivindicacaoDto)
        {
            return new ClaimDTO();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReivindicacao(int id, ClaimDTO reivindicacaoDto)
        {
            return Ok();
        }
    }
}
