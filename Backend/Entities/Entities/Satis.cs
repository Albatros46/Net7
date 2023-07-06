using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Satis:IEntity
    {//Verkaufen
        public virtual int Id { get; set; }
        public virtual Product productId { get; set; }
        public virtual Musteri musteriId { get; set; }
        public virtual Personal personalId { get; set; }
        public virtual DateTime Date { get; set; } = DateTime.Now;//  DateTime.Now  kullanmak zorunlu degil
        public virtual int Quantity { get; set; }
    }
}
