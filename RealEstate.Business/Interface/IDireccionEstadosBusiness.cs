using RealEstate.Models.Common;
using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Business.Interface
{
    public interface IDireccionEstadosBusiness : IBaseBusiness<DireccionEstados, int>
    {
        IEnumerable<SearchItemModel> SearchEstate(string word);
    }
}
