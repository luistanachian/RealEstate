using RealEstate.Dao.Interface;
using RealEstate.Models.Entity;
using RealEstate.Repository.Interface;
using System.Collections.Generic;

namespace RealEstate.Repository.Class
{
    public class DireccionPaisesRepository : IDireccionPaisesRepository
    {
        private readonly IDireccionPaisesDao _direccionPaisesDao;
        public DireccionPaisesRepository(IDireccionPaisesDao direccionPaisesDao)
        {
            _direccionPaisesDao = direccionPaisesDao;
        }

        public bool Delete(string id)
        {
            var rowsCount = _direccionPaisesDao.Delete(id);
            return rowsCount > 0;
        }

        public IEnumerable<DireccionPaises> GetAll()
        {
            return _direccionPaisesDao.GetAll();
        }

        public DireccionPaises GetById(string id)
        {
            return _direccionPaisesDao.GetById(id);
        }

        public bool Insert(DireccionPaises entity)
        {
            var rowsCount = _direccionPaisesDao.Insert(entity);
            return rowsCount > 0;
        }

        public bool Update(DireccionPaises entity)
        {
            var rowsCount = _direccionPaisesDao.Update(entity);
            return rowsCount > 0;
        }
    }
}
