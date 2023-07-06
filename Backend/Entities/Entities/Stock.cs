using Base.Entity;

namespace Entities.Entities
{
    public class Stock:IEntity
    {
        public virtual int Id { get; set; }
        public virtual Product productId { get; set; }
        public virtual Personal personalId { get; set; }
        public virtual DateTime Date { get; set; }//datum
        public virtual int Quantity { get; set; }//adet/stück/menge
    }
}
