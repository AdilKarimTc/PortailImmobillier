using PortailImmobillier.Web.Models;
using PortailImmobillier.Data.Entities;
using System.Threading.Tasks;
using System;

namespace PortailImmobillier.Web.Interfaces
{
    public interface IComptesService 
    {
        Task<Utilisateur> CreateUtilisateurAsync(RegisterModel model);
    }

}