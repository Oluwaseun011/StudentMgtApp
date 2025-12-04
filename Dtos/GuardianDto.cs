using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMgtApp.Dtos
{
    public class GuardianDto
    {
        public int Id{ get; set; }
        public string CreatedBy{ get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public string Email{ get; set; } = default!;
        public string Password{ get; set; } = default!;
        public string Role{ get; set; } = default!;
        public string Name{ get; set; } = default!;
    }

    public record RegisterGuardianRequest(string Email, string Password, string Name);
    public record RegisterGuardianResponse(int Id, string Name);
}