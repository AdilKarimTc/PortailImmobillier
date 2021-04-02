using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortailImmobillier.Data.Entities;

namespace PortailImmobillier.Data.DatabaseContetxts.AthenticationDbContext
{
    public class AuthenticationDbContext : IdentityDbContext<Utilisateur>{

        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
            : base(options)
        {

        }

    }



}