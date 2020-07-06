using RealEstate.Models.Common;
using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Dao.Interface
{
    public interface IDireccionLocalidadesDao : IBaseDao<DireccionLocalidades, string>
    {
        IEnumerable<SearchItemModel> SearchLocalidades(string word, int top);
    }
}