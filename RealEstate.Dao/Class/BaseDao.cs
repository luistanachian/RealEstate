using RealEstate.Dao.Context;
using RealEstate.Dao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RealEstate.Dao.Class
{
    public class BaseDao<TEntity, TId> : IBaseDao<TEntity, TId> 
        where TEntity : class
        where TId : class
    {
        public IEnumerable<TEntity> GetAll()
        {
            using (var db = new RealEstateContext())
            {
                return db.Set<TEntity>().ToList();
            }
        }
        public TEntity GetById(TId id)
        {
            using (var db = new RealEstateContext())
            {
                return db.Set<TEntity>().Find(id);
            }
        }
        public TEntity GetOneByFunc(Func<TEntity, bool> conditionLambda)
        {
            using (var db = new RealEstateContext())
            {
                return db.Set<TEntity>().FirstOrDefault(conditionLambda);
            }
        }
        public IEnumerable<TEntity> GetListByFunc(Func<TEntity, bool> conditionLambda)
        {
            using (var db = new RealEstateContext())
            {
                return db.Set<TEntity>().Where(conditionLambda).ToList();
            }
        }
        public int Insert(TEntity entity)
        {
            using (var db = new RealEstateContext())
            {
                db.Set<TEntity>().Add(entity);
                return db.SaveChanges();
            }
        }
        public int Update(TEntity entity)
        {
            using (var db = new RealEstateContext())
            {
                db.Set<TEntity>().Update(entity);
                return db.SaveChanges();
            }
        }
        public int Delete(TId id)
        {
            using (var db = new RealEstateContext())
            {
                var entity = db.Set<TEntity>().Find(id);
                if (entity != null)
                {
                    db.Set<TEntity>().Remove(entity);
                    return db.SaveChanges();
                }
                return 0;
            }
        }
    }
}