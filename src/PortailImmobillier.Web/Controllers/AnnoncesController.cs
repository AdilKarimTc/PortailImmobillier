using Microsoft.AspNetCore.Mvc;

namespace PortailImmobillier.Web.Controllers{
    
    public class AnnoncesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }


}