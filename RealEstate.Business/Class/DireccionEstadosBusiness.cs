using RealEstate.Business.Interface;
using RealEstate.Models.Common;
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

        public bool Delete(int id)
        {
            return _direccionEstadosRepository.Delete(id);
        }

        public IEnumerable<SearchItemModel> SearchEstate(string word)
        {
            var top = 5; //TODO agregar en appsettings
            return _direccionEstadosRepository.SearchEstate(word, top);
        }
        public IEnumerable<DireccionEstados> GetAll()
        {
            return _direccionEstadosRepository.GetAll();
        }

        public DireccionEstados GetById(int id)
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
