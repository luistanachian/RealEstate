using RealEstate.Dao.Interface;
using RealEstate.Models.Common;
using RealEstate.Models.Entity;
using RealEstate.Repository.Interface;
using System.Collections.Generic;

namespace RealEstate.Repository.Class
{
    public class DireccionLocalidadesRepository : IDireccionLocalidadesRepository
    {
        private readonly IDireccionLocalidadesDao _DireccionLocalidadesDao;
        public DireccionLocalidadesRepository(IDireccionLocalidadesDao DireccionLocalidadesDao)
        {
            _DireccionLocalidadesDao = DireccionLocalidadesDao;
        }

        public bool Delete(int id)
        {
            var rowsCount = _DireccionLocalidadesDao.Delete(id);
            return rowsCount > 0;
        }

        public IEnumerable<SearchItemModel> SearchLocalidades(string word, int top)
        {
            return _DireccionLocalidadesDao.SearchLocalidades(word, top);
        }
        public IEnumerable<DireccionLocalidades> GetAll()
        {
            return _DireccionLocalidadesDao.GetAll();
        }

        public DireccionLocalidades GetById(int id)
        {
            return _DireccionLocalidadesDao.GetById(id);
        }

        public IEnumerable<DireccionLocalidades> GetByIdEstado(int idEstado)
        {
            return _DireccionLocalidadesDao.GetListByFunc(e => e.IdEstado == idEstado);
        }

        public bool Insert(DireccionLocalidades entity)
        {
            var rowsCount = _DireccionLocalidadesDao.Insert(entity);
            return rowsCount > 0;
        }


        public bool Update(DireccionLocalidades entity)
        {
            var rowsCount = _DireccionLocalidadesDao.Update(entity);
            return rowsCount > 0;
        }
    }
}
