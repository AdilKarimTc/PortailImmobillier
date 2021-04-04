using PortailImmobillier.Web.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using PortailImmobillier.Data.Entities;

namespace PortailImmobillier.Web.Interfaces
{
    public interface IAnnoncesService
    {
        Task AddAnnonce(AnnoncesModel model);
        IEnumerable<Annonce> GetAllAnnonces();
    }
}