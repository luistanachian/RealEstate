using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Repository.Interface
{
    public interface IUsuariosRepository : IBaseRepository<Usuarios, string>
    {
        Usuarios GetByEmail(string email);
        Usuarios Login(string email, string clave);
        IEnumerable<Usuarios> GetInmobiliariasByBarrio(string idBarrio);
        IEnumerable<Usuarios> GetInmobiliariasByLocalidad(string idLocalidad);
        IEnumerable<Usuarios> GetInmobiliariasByEstado(string idEstado);
    }
}
