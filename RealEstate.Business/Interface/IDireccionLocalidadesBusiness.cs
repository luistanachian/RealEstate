using RealEstate.Models.Common;
using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Business.Interface
{
    public interface IDireccionLocalidadesBusiness : IBaseBusiness<DireccionLocalidades, int>
    {
        IEnumerable<SearchItemModel> SearchLocalidades(string word);
        IEnumerable<DireccionLocalidades> GetByIdEstado(int idEstado);
    }
}
