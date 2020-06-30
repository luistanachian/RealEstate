using System.Collections.Generic;

namespace RealEstate.Models.Entity
{
    public partial class PublicacionesPlanes
    {
        public PublicacionesPlanes()
        {
            Publicaciones = new HashSet<Publicaciones>();
        }

        public string IdPlan { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Visibilidad { get; set; }
        public string IdMoneda { get; set; }
        public decimal Monto { get; set; }
        public short Dias { get; set; }
        public bool Destacado { get; set; }
        public bool SuperDestacado { get; set; }

        public virtual ICollection<Publicaciones> Publicaciones { get; set; }
    }
}
