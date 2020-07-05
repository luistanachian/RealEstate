
using RealEstate.Business.Interface;
using RealEstate.Models.Entity;
using RealEstate.Repository.Interface;
using System.Collections.Generic;

namespace RealEstate.Business.Class
{
    public class DireccionBarriosBusiness : IDireccionBarriosBusiness
    {
        private readonly IDireccionBarriosRepository _DireccionBarriosRepository;
        public DireccionBarriosBusiness(IDireccionBarriosRepository DireccionBarriosRepository)
        {
            _DireccionBarriosRepository = DireccionBarriosRepository;
        }

        public bool Delete(string id)
        {
            return _DireccionBarriosRepository.Delete(id);
        }

        public IEnumerable<DireccionBarrios> GetAll()
        {
            return _DireccionBarriosRepository.GetAll();
        }

        public DireccionBarrios GetById(string id)
        {
            return _DireccionBarriosRepository.GetById(id);
        }
        public IEnumerable<DireccionBarrios> GetByIdLocalidad(string idLocalidad)
        {
            return _DireccionBarriosRepository.GetByIdLocalidad(idLocalidad);
        }

        public bool Insert(DireccionBarrios entity)
        {
            return _DireccionBarriosRepository.Insert(entity);
        }

        public bool Update(DireccionBarrios entity)
        {
            return _DireccionBarriosRepository.Update(entity);
        }
    }
}
