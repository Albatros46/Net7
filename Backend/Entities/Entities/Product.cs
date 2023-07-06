using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Product:IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Category categoryId { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual decimal Price { get; set; }
    }
}
