using RealEstate.Business.Interface;
using RealEstate.Models.Entity;
using RealEstate.Repository.Interface;
using System.Collections.Generic;

namespace RealEstate.Business.Class
{
    public class MonedasBusiness : IMonedasBusiness
    {
        private readonly IMonedasRepository _monedasRepository;
        public MonedasBusiness(IMonedasRepository monedasRepository)
        {
            _monedasRepository = monedasRepository;
        }

        public bool Delete(int id)
        {
            return _monedasRepository.Delete(id);
        }

        public IEnumerable<Monedas> GetAll()
        {
            return _monedasRepository.GetAll();
        }
        public Monedas GetById(int id)
        {
            return _monedasRepository.GetById(id);
        }
        public bool Insert(Monedas entity)
        {
            return _monedasRepository.Insert(entity);
        }
        public bool Update(Monedas entity)
        {
            return _monedasRepository.Update(entity);
        }
    }
}