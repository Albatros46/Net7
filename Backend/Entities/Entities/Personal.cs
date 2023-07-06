using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Personal:IEntity
    {
        public virtual int Id { get; set; }
        public virtual string VollName { get; set; }//adi soyadi
        public virtual string Telefon { get; set; }
        public virtual string Email { get; set; }
        public virtual string Adress { get; set; }
        public virtual bool isActive { get; set; } = true;
    }
}
