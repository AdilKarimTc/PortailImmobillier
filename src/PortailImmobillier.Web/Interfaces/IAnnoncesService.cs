using PortailImmobillier.Web.Models;
using System.Threading.Tasks;

namespace PortailImmobillier.Web.Interfaces
{
    public interface IAnnoncesService
    {
        Task AddAnnonce(AnnoncesModel model);
    }
}