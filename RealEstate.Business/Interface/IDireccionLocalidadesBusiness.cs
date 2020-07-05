using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Business.Interface
{
    public interface IDireccionLocalidadesBusiness : IBaseBusiness<DireccionLocalidades, string>
    {
        IEnumerable<DireccionLocalidades> GetByIdEstado(string idEstado);
    }
}
