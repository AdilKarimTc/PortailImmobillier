using Microsoft.AspNetCore.Mvc;
using PortailImmobillier.Web.Models;
using System;

namespace PortailImmobillier.Web.Controllers
{
    public class ComptesController : Controller
    {   

        [HttpGet]
        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {   
            if(!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }    
        

        [HttpGet]
        public IActionResult Register(){
            return View();
        }
        
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if(!ModelState.IsValid) return View();
            throw new NotImplementedException();
        }



    }
}