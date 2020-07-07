using System;
using System.Collections.Generic;

namespace RealEstate.Models.Entity
{
    public partial class DireccionBarrios
    {
        public int IdBarrio { get; set; }
        public int IdLocalidad { get; set; }
        public string Barrio { get; set; }
    }
}
