using Base.Entity;

namespace Entities.Entities
{
    public class KullaniciYetkileri:IEntity
    {
        public virtual int Id { get; set; }
        public virtual Yetkiler yetkiId { get; set; }//One to One- bir kullanicinin bir yetikisi olacagi icin.
       
        public virtual Personal personalId { get; set; }//One to One- bir kullanicinin bir yetikisi olacagi icin.
        public virtual string Password { get; set; }
    }
}
