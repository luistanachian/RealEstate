using System.Collections.Generic;

namespace RealEstate.Models.Entity
{
    public partial class DireccionPaises
    {
        public DireccionPaises()
        {
            DireccionEstados = new HashSet<DireccionEstados>();
        }

        public string IdPais { get; set; }
        public string Pais { get; set; }

        public virtual ICollection<DireccionEstados> DireccionEstados { get; set; }
    }
}
