using Microsoft.AspNetCore.Mvc;
using PortailImmobillier.Web.Models;
using System;
using PortailImmobillier.Web.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PortailImmobillier.Data.Entities;
using System.Text;

namespace PortailImmobillier.Web.Controllers
{
    public class ComptesController : Controller
    {   
        private readonly IComptesService _comptesService;
        private readonly SignInManager<Utilisateur> _signInManager;


        public ComptesController(IComptesService comptesService, SignInManager<Utilisateur> signInManager)
        {
            _comptesService = comptesService;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {   
            if(!ModelState.IsValid) return View();

            try 
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                if(!result.Succeeded)
                {
                    ModelState.AddModelError("","Login Failed Please check your details");
                    return View();
                }
                return LocalRedirect("~/");
                
            }
            catch(Exception e)
            {

                ModelState.AddModelError("", e.Message);
                return View();

            }
            
        }    
        

        [HttpGet]
        public IActionResult Register(){
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid) return View();
             try
            {
                var user = await _comptesService.CreateUtilisateurAsync(model);
                await _signInManager.SignInAsync(user, isPersistent: false);
                return LocalRedirect("~/");
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }

        }
    }
}

