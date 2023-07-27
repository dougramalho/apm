using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Core.DTOs
{
    public class PolicyDTO
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string CoverageType { get; set; }
        public decimal PremiumValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
