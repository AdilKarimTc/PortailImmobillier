using Microsoft.AspNetCore.Identity;
namespace PortailImmobillier.Data.Entities
{
    public class Utilisateur : IdentityUser
    {
        public string NomComplet{get; set;}


    }
}