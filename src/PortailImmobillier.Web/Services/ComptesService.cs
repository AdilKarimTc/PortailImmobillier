using PortailImmobillier.Web.Models;
using PortailImmobillier.Data.Entities;
using System.Threading.Tasks;
using System;
using PortailImmobillier.Web.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Text;

namespace PortailImmobillier.Web.Services
{
    public class ComptesService : IComptesService
    {
        private readonly UserManager<Utilisateur> _userManager;
        public ComptesService(UserManager<Utilisateur> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Utilisateur> CreateUtilisateurAsync(RegisterModel model){
            if(model is null) throw new ArgumentNullException(message: "Invalid Details Provided", null);
            var user = new Utilisateur
            {
                UserName = model.Email,
                Email = model.Email,
                NomComplet = model.FullName
            };

            var result = await _userManager.CreateAsync(user,model.Password);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException(message: AddErrors(result),null);
            }

        return user;
        }

    private string AddErrors(IdentityResult result)
        {
           StringBuilder sb = new StringBuilder(); 
            foreach(var error in result.Errors)
            {
                sb.Append(error.Description + "  ");
            }

            return sb.ToString();
        }
    }
}
