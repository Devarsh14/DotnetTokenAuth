using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotnetTokenAuth.Models
{
    public class IdentiyContext : IdentityDbContext<IdentityUser>
    {
        public IdentiyContext(DbContextOptions options) : base(options)
        {
                
        }
    }
}
