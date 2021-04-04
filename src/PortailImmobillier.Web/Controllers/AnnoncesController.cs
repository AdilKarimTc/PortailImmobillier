using Microsoft.AspNetCore.Mvc;
using System;
using PortailImmobillier.Web.Models;

namespace PortailImmobillier.Web.Controllers{
    
    public class AnnoncesController : Controller
    {
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

        
        public IActionResult Add(AnnoncesModel model)
        {
            throw new NotImplementedException();
        }

    }
    



}