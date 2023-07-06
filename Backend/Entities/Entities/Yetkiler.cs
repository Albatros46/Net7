using Base.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Yetkiler:IEntity
    {//Kullanici yetkileri burda olacak.Der  Benutzer rule hier beschreiben
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
