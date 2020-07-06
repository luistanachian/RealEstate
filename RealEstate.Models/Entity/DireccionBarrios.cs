using System;
using System.Collections.Generic;

namespace RealEstate.Models.Entity
{
    public partial class DireccionBarrios
    {
        public DireccionBarrios()
        {
            Publicaciones = new HashSet<Publicaciones>();
            Usuarios = new HashSet<Usuarios>();
        }

        public string IdBarrio { get; set; }
        public string IdLocalidad { get; set; }
        public string Barrio { get; set; }

        public virtual DireccionLocalidades IdLocalidadNavigation { get; set; }
        public virtual ICollection<Publicaciones> Publicaciones { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
