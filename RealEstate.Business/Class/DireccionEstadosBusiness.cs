using RealEstate.Business.Interface;
using RealEstate.Models.Entity;
using RealEstate.Repository.Interface;
using System.Collections.Generic;

namespace RealEstate.Business.Class
{
    public class DireccionEstadosBusiness : IDireccionEstadosBusiness
    {
        private readonly IDireccionEstadosRepository _direccionEstadosRepository;
        public DireccionEstadosBusiness(IDireccionEstadosRepository direccionEstadosRepository)
        {
            _direccionEstadosRepository = direccionEstadosRepository;
        }

        public bool Delete(string id)
        {
            return _direccionEstadosRepository.Delete(id);
        }

        public IEnumerable<DireccionEstados> GetAll()
        {
            return _direccionEstadosRepository.GetAll();
        }

        public DireccionEstados GetById(string id)
        {
            return _direccionEstadosRepository.GetById(id);
        }

        public bool Insert(DireccionEstados entity)
        {
            return _direccionEstadosRepository.Insert(entity);
        }

        public bool Update(DireccionEstados entity)
        {
            return _direccionEstadosRepository.Update(entity);
        }
    }
}
