using RealEstate.Business.Interface;
using RealEstate.Models.Entity;
using RealEstate.Repository.Interface;
using System.Collections.Generic;

namespace RealEstate.Business.Class
{
    public class DireccionLocalidadesBusiness : IDireccionLocalidadesBusiness
    {
        private readonly IDireccionLocalidadesRepository _DireccionLocalidadesRepository;
        public DireccionLocalidadesBusiness(IDireccionLocalidadesRepository DireccionLocalidadesRepository)
        {
            _DireccionLocalidadesRepository = DireccionLocalidadesRepository;
        }

        public bool Delete(string id)
        {
            return _DireccionLocalidadesRepository.Delete(id);
        }

        public IEnumerable<DireccionLocalidades> GetAll()
        {
            return _DireccionLocalidadesRepository.GetAll();
        }

        public DireccionLocalidades GetById(string id)
        {
            return _DireccionLocalidadesRepository.GetById(id);
        }
        public IEnumerable<DireccionLocalidades> GetByIdEstado(string idEstado)
        {
            return _DireccionLocalidadesRepository.GetByIdEstado(idEstado);
        }

        public bool Insert(DireccionLocalidades entity)
        {
            return _DireccionLocalidadesRepository.Insert(entity);
        }

        public bool Update(DireccionLocalidades entity)
        {
            return _DireccionLocalidadesRepository.Update(entity);
        }
    }
}
