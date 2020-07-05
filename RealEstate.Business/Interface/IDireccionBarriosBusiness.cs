using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Business.Interface
{
    public interface IDireccionBarriosBusiness : IBaseBusiness<DireccionBarrios, string>
    {
        IEnumerable<DireccionBarrios> GetByIdLocalidad(string idLocalidad);
    }
}
