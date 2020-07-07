using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Business.Interface
{
    public interface IDireccionBarriosBusiness : IBaseBusiness<DireccionBarrios, int>
    {
        IEnumerable<DireccionBarrios> GetByIdLocalidad(int idLocalidad);
    }
}
