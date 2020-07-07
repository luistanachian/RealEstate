using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Business.Interface
{
    public interface IDireccionEstadosBusiness : IBaseBusiness<DireccionEstados, int>
    {
        IEnumerable<DireccionEstados> SearchEstate(string word);
    }
}
