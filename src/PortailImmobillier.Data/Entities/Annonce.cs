namespace PortailImmobillier.Data.Entities{
    public class Annonce : BaseEntity
    {
        public string Titre{ get; set; }
        public string ImageUrl{ get; set; }
        public double Prix{ get; set; }
        public string Description{ get; set;}
        public int Chambres{ get; set; }
        public int Toilettes{ get; set;}
        public string Adresse{ get; set; }

        public string ContactPhoneNumber{ get; set; }

    }
}