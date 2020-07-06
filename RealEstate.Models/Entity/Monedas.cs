using System;
using System.Collections.Generic;

namespace RealEstate.Models.Entity
{
    public partial class Monedas
    {
        public Monedas()
        {
            Publicaciones = new HashSet<Publicaciones>();
        }

        public string IdMoneda { get; set; }
        public string Moneda { get; set; }

        public virtual ICollection<Publicaciones> Publicaciones { get; set; }
    }
}
