using System;
using System.Collections.Generic;

namespace RealEstate.Dao.Interface
{
    public interface IBaseDao<TEntity, TId>
        where TEntity : class
        where TId : notnull
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(TId id);
        TEntity GetOneByFunc(Func<TEntity, bool> conditionLambda);
        IEnumerable<TEntity> GetListByFunc(Func<TEntity, bool> conditionLambda, int top = 0);
        int Insert(TEntity entity);
        int Update(TEntity entity);
        int Delete(TId id);
    }
}
