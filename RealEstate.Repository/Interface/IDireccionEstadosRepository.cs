using RealEstate.Models.Entity;
using System.Collections.Generic;

namespace RealEstate.Repository.Interface
{
    public interface IDireccionEstadosRepository : IBaseRepository<DireccionEstados, string>
    {
        IEnumerable<DireccionEstados> SearchEstate(string word, int top);
    }
}
