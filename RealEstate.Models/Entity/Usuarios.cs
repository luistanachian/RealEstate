using System.Collections.Generic;

namespace RealEstate.Models.Entity
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Publicaciones = new HashSet<Publicaciones>();
        }

        public string IdUsuario { get; set; }
        public string IdBarrio { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Dueño { get; set; }
        public string Nombre { get; set; }
        public string Documento1 { get; set; }
        public string Documento2 { get; set; }
        public string Documento3 { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public int? CountMeGusta { get; set; }
        public string UrlFacebook { get; set; }
        public string UrlInstagram { get; set; }
        public string Whatsapp { get; set; }
        public string EmailContacto { get; set; }
        public string DirCalle { get; set; }
        public string DirPiso { get; set; }
        public string DirLocal { get; set; }
        public string DirLatitud { get; set; }
        public string DirLongitud { get; set; }
        public string Descripcion { get; set; }

        public virtual DireccionBarrios IdBarrioNavigation { get; set; }
        public virtual ICollection<Publicaciones> Publicaciones { get; set; }
    }
}
