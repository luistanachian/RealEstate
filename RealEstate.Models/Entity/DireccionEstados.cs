using System;
using System.Collections.Generic;

namespace RealEstate.Models.Entity
{
    public partial class DireccionEstados
    {
        public DireccionEstados()
        {
            DireccionLocalidades = new HashSet<DireccionLocalidades>();
        }

        public string IdEstado { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<DireccionLocalidades> DireccionLocalidades { get; set; }
    }
}
