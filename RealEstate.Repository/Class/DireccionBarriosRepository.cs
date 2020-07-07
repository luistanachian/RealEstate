using RealEstate.Dao.Interface;
using RealEstate.Models.Entity;
using RealEstate.Repository.Interface;
using System.Collections.Generic;

namespace RealEstate.Repository.Class
{
    public class DireccionBarriosRepository : IDireccionBarriosRepository
    {
        private readonly IDireccionBarriosDao _DireccionBarriosDao;
        public DireccionBarriosRepository(IDireccionBarriosDao DireccionBarriosDao)
        {
            _DireccionBarriosDao = DireccionBarriosDao;
        }

        public bool Delete(int id)
        {
            var rowsCount = _DireccionBarriosDao.Delete(id);
            return rowsCount > 0;
        }

        public IEnumerable<DireccionBarrios> GetAll()
        {
            return _DireccionBarriosDao.GetAll();
        }

        public DireccionBarrios GetById(int id)
        {
            return _DireccionBarriosDao.GetById(id);
        }

        public IEnumerable<DireccionBarrios> GetByIdLocalidad(int idLocalidad)
        {
            return _DireccionBarriosDao.GetListByFunc(e => e.IdLocalidad == idLocalidad);
        }

        public bool Insert(DireccionBarrios entity)
        {
            var rowsCount = _DireccionBarriosDao.Insert(entity);
            return rowsCount > 0;
        }

        public bool Update(DireccionBarrios entity)
        {
            var rowsCount = _DireccionBarriosDao.Update(entity);
            return rowsCount > 0;
        }
    }
}
