using System;
using System.Collections.Generic;

namespace RealEstate.Models.Entity
{
    public partial class DireccionLocalidades
    {
        public int IdLocalidad { get; set; }
        public int IdEstado { get; set; }
        public string Localidad { get; set; }
    }
}
