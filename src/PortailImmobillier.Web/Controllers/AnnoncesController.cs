using Microsoft.AspNetCore.Mvc;
using System;
using PortailImmobillier.Web.Models;
using PortailImmobillier.Web.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization; 


namespace PortailImmobillier.Web.Controllers{
    
    [Authorize]
    public class AnnoncesController : Controller
    {
        private readonly IAnnoncesService _annonceService;
        
        public AnnoncesController(IAnnoncesService annonceService)
        {
            _annonceService = annonceService;
        }


        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            var annonces = _annonceService.GetAllAnnonces();
            return View(annonces);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(AnnoncesModel model)
        {
            try 
            {
                await _annonceService.AddAnnonce(model);
                 return RedirectToAction(nameof(Index));
            
            }
            catch(Exception e)
            {
                return RedirectToAction(nameof(Index));
            }

        }

    }
    



}