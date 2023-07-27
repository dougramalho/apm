using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApmDemonstracao.Core.DTOs
{
    public class ClaimDTO
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
