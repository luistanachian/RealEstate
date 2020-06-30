using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Repository.Interface
{
    public interface IDireccionLocalidadesRepository : IBaseRepository<DireccionLocalidades, string>
    {
        IEnumerable<DireccionLocalidades> GetByIdEstado(string idEstado);
    }
}
