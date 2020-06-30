using System.Collections.Generic;

namespace RealEstate.Models.Entity
{
    public partial class DireccionLocalidades
    {
        public DireccionLocalidades()
        {
            DireccionBarrios = new HashSet<DireccionBarrios>();
        }

        public string IdLocalidad { get; set; }
        public string IdEstado { get; set; }
        public string Localidad { get; set; }

        public virtual DireccionEstados IdEstadoNavigation { get; set; }
        public virtual ICollection<DireccionBarrios> DireccionBarrios { get; set; }
    }
}
