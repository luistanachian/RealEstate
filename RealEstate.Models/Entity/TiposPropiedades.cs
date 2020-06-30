using System.Collections.Generic;

namespace RealEstate.Models.Entity
{
    public partial class TiposPropiedades
    {
        public TiposPropiedades()
        {
            Publicaciones = new HashSet<Publicaciones>();
        }

        public string IdTipoPropiedad { get; set; }
        public string TipoPropiedad { get; set; }

        public virtual ICollection<Publicaciones> Publicaciones { get; set; }
    }
}
