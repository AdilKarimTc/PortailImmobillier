using System.Globalization;
using Microsoft.EntityFrameworkCore;
using PortailImmobillier.Data.Entities;

namespace PortailImmobillier.Data.DatabseContexts.ApplicationDbContext{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        } 

         public DbSet<Annonce> Annonces {get; set;}
         public DbSet<Contact> Contacts {get; set;}   

    }


}