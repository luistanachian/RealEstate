using RealEstate.Dao.Interface;
using RealEstate.Models.Entity;
using RealEstate.Repository.Interface;
using System.Collections.Generic;

namespace RealEstate.Repository.Class
{
    public class MonedasRepository : IMonedasRepository
    {
        private readonly IMonedasDao _monedasDao;
        public MonedasRepository(IMonedasDao monedasDao)
        {
            _monedasDao = monedasDao;
        }
        public Monedas GetById(int id)
        {
            return _monedasDao.GetById(id);
        }
        public bool Delete(int id)
        {
            var rowsCount = _monedasDao.Delete(id);
            return rowsCount > 0;
        }
        public bool Insert(Monedas entity)
        {
            var rowsCount = _monedasDao.Insert(entity);
            return rowsCount > 0;
        }
        public bool Update(Monedas entity)
        {
            var rowsCount = _monedasDao.Update(entity);
            return rowsCount > 0;
        }

        public IEnumerable<Monedas> GetAll()
        {
            return _monedasDao.GetAll();
        }
    }
}
