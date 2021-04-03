using System;
namespace PortailImmobillier.Data.Entities
{
    public abstract class BaseEntity
    {
        public string Id{ get; set; }
        public bool IsSupprime{ get; set; }
        public DateTime CreeLe{ get; set; }
        public DateTime ModifieLe{ get; set; }
        public DateTime SupprimeLe{ get; set; }


    }
}