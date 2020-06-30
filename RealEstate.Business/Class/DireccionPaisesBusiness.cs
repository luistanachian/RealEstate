using RealEstate.Business.Interface;
using RealEstate.Models.Entity;
using RealEstate.Repository.Interface;
using System.Collections.Generic;

namespace RealEstate.Business.Class
{
    public class DireccionPaisesBusiness : IDireccionPaisesBusiness
    {
        private readonly IDireccionPaisesRepository _direccionPaisesRepository;
        public DireccionPaisesBusiness(IDireccionPaisesRepository direccionPaisesRepository)
        {
            _direccionPaisesRepository = direccionPaisesRepository;
        }

        public bool Delete(string id)
        {
            return _direccionPaisesRepository.Delete(id);
        }

        public IEnumerable<DireccionPaises> GetAll()
        {
            return _direccionPaisesRepository.GetAll();
        }

        public DireccionPaises GetById(string id)
        {
            return _direccionPaisesRepository.GetById(id);
        }

        public bool Insert(DireccionPaises entity)
        {
            return _direccionPaisesRepository.Insert(entity);
        }

        public bool Update(DireccionPaises entity)
        {
            return _direccionPaisesRepository.Update(entity);
        }
    }
}
