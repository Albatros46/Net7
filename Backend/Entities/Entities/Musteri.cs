using Base.Entity;

namespace Entities.Entities
{
    public class Musteri:IEntity
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }//AdiSoyadi/VornameNachname
        public virtual string Telefon { get; set; }
        public virtual string Email { get; set; }
        public virtual string Adress { get; set; }
        public virtual Sehirler sehirId { get; set; }
    }
}
