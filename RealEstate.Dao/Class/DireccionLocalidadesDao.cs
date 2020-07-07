using RealEstate.Dao.Context;
using RealEstate.Dao.Interface;
using RealEstate.Models.Common;
using RealEstate.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace RealEstate.Dao.Class
{
    public class DireccionLocalidadesDao : BaseDao<DireccionLocalidades, int>, IDireccionLocalidadesDao
    {
        public IEnumerable<SearchItemModel> SearchLocalidades(string word, int top)
        {
            using (var db = new RealEstateContext())
            {
                var lista = (from lo in db.DireccionLocalidades
                                  join es in db.DireccionEstados on lo.IdEstado equals es.IdEstado
                                  where 
                                      lo.Localidad.Contains(word) 
                                      || es.Estado.Contains(word) ||
                                      (lo.Localidad + " " + es.Estado).Contains(word) 
                             select new SearchItemModel
                                  {
                                      Id = lo.IdLocalidad, 
                                      Texto = $"{lo.Localidad}, {es.Estado}"
                                  }).Take(top).ToList();

                return lista;
            }
        }
    }
}