using Microsoft.AspNetCore.Mvc;
using System;
using PortailImmobillier.Web.Models;
using PortailImmobillier.Web.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PortailImmobillier.Data.Entities;


namespace PortailImmobillier.Web.Controllers{
    
    public class AnnoncesController : Controller
    {
        private readonly IAnnoncesService _annonceService;
        public AnnoncesController(IAnnoncesService annonceService)
        {
            _annonceService = annonceService;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        
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