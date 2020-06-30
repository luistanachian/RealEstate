using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Repository.Interface
{
    public interface IDireccionBarriosRepository : IBaseRepository<DireccionBarrios, string>
    {
        IEnumerable<DireccionBarrios> GetByIdLocalidad(string idLocalidad);
    }
}
