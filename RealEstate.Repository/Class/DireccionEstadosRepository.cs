using RealEstate.Dao.Interface;
using RealEstate.Models.Entity;
using RealEstate.Repository.Interface;
using System.Collections.Generic;

namespace RealEstate.Repository.Class
{
    public class DireccionEstadosRepository : IDireccionEstadosRepository
    {
        private readonly IDireccionEstadosDao _direccionEstadosDao;
        public DireccionEstadosRepository(IDireccionEstadosDao direccionEstadosDao)
        {
            _direccionEstadosDao = direccionEstadosDao;
        }

        public bool Delete(string id)
        {
            var rowsCount = _direccionEstadosDao.Delete(id);
            return rowsCount > 0;
        }

        public IEnumerable<DireccionEstados> GetAll()
        {
            return _direccionEstadosDao.GetAll();
        }

        public DireccionEstados GetById(string id)
        {
            return _direccionEstadosDao.GetById(id);
        }

        public IEnumerable<DireccionEstados> GetByIdPais(string idPais)
        {
            return _direccionEstadosDao.GetListByFunc(e => e.IdPais == idPais);
        }

        public bool Insert(DireccionEstados entity)
        {
            var rowsCount = _direccionEstadosDao.Insert(entity);
            return rowsCount > 0;
        }

        public bool Update(DireccionEstados entity)
        {
            var rowsCount = _direccionEstadosDao.Update(entity);
            return rowsCount > 0;
        }
    }
}
