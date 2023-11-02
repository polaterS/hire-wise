using Microsoft.AspNetCore.Identity;

namespace HireWise.Domain.Entities.Identity
{
    public class AppRole : IdentityRole<string>
    {
        public ICollection<Employee>Employees { get; set; }
        public ICollection<Endpoint> Endpoints { get; set; }
    }
}
