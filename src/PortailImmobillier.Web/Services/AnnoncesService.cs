using PortailImmobillier.Web.Models;
using System.Threading.Tasks;
using PortailImmobillier.Data.DatabseContexts.ApplicationDbContext;
using PortailImmobillier.Data.Entities;
using PortailImmobillier.Web.Interfaces;
using System.Collections.Generic;
using System;


namespace PortailImmobillier.Web.Services
{
    public class AnnoncesService : IAnnoncesService
    {
        private readonly ApplicationDbContext _dbContext;

        public AnnoncesService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public IEnumerable<Annonce> GetAllAnnonces()
        {
            /// We need To return a list of Annonces
            return _dbContext.Annonces;
        }




        public async Task AddAnnonce(AnnoncesModel model)
        {
            var Annonce = new Annonce
            {
                Id = Guid.NewGuid().ToString(),
                Titre = model.Titre,
                ImageUrl = model.ImageUrl,
                Prix = model.Prix,
                Description = model.Description,
                Chambres = model.Chambres,
                Toilettes = model.Toilettes,
                Adresse = model.Adresse,
                ContactPhoneNumber = model.ContactPhoneNumber
            };

            await _dbContext.AddAsync(Annonce);
            await _dbContext.SaveChangesAsync();

        }
        
    }
}