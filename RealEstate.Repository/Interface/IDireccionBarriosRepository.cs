using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Repository.Interface
{
    public interface IDireccionBarriosRepository : IBaseRepository<DireccionBarrios, int>
    {
        IEnumerable<DireccionBarrios> GetByIdLocalidad(int idLocalidad);
    }
}
