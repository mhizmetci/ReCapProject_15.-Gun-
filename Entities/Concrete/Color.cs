using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Color : IEntity
    {
        //ÇCK: Çıplak Class kalmasın.
        public int ColorId { get; set; }
        public string ColorName { get; set; }

    }
}
