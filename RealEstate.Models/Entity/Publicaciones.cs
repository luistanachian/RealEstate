using System;
using System.Collections.Generic;

namespace RealEstate.Models.Entity
{
    public partial class Publicaciones
    {
        public string IdPub { get; set; }
        public string IdUsuario { get; set; }
        public string IdTipoPropiedad { get; set; }
        public string IdPlan { get; set; }
        public string IdBarrio { get; set; }
        public string IdMoneda { get; set; }
        public bool? CicloDiario { get; set; }
        public bool? CicloSemanal { get; set; }
        public bool? CicloMensual { get; set; }
        public short? CicloCantidad { get; set; }
        public decimal Monto { get; set; }
        public decimal? Expensas { get; set; }
        public decimal? Impuestos { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int CountVistas { get; set; }
        public int CountContactados { get; set; }
        public short? CantAmbientes { get; set; }
        public short? CantHabitaciones { get; set; }
        public short? CantBaños { get; set; }
        public short? CantCocheras { get; set; }
        public short? CantBalcones { get; set; }
        public bool? PermiteMascotas { get; set; }
        public bool? PermiteNiños { get; set; }
        public bool? SrvGas { get; set; }
        public bool? SrvElectricidad { get; set; }
        public bool? SrvAgua { get; set; }
        public bool? SrvInternet { get; set; }
        public bool? SrvTelefonico { get; set; }
        public string DirCalle { get; set; }
        public string DirPiso { get; set; }
        public string DirLocal { get; set; }
        public string DirLatitud { get; set; }
        public string DirLongitud { get; set; }
        public string Descripcion { get; set; }

        public virtual DireccionBarrios IdBarrioNavigation { get; set; }
        public virtual Monedas IdMonedaNavigation { get; set; }
        public virtual PublicacionesPlanes IdPlanNavigation { get; set; }
        public virtual TiposPropiedades IdTipoPropiedadNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
