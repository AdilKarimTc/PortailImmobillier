using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PortailImmobillier.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace PortailImmobillier.Data.DatabseContexts.AuthenticationDbContext {
    public class AuthenticationDbContext : IdentityDbContext<Utilisateur>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
            : base(options)
        {

        }
    }
}