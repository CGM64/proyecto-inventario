using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace proyecto_inventario.Models
{
    public class LoginDbContext : IdentityDbContext<ApplicationUsers>
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> Options) : base(Options)
        {

        }
    }
}
