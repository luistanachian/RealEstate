using RealEstate.Models.Common;
using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Repository.Interface
{
    public interface IDireccionLocalidadesRepository : IBaseRepository<DireccionLocalidades, int>
    {
        IEnumerable<DireccionLocalidades> GetByIdEstado(int idEstado);
        IEnumerable<SearchItemModel> SearchLocalidades(string word, int top);
    }
}
