using System.Collections.Generic;

namespace RealEstate.Business.Interface
{
    public interface IBaseBusiness<TEntity, TId>
        where TEntity : class
        where TId : notnull
    {
        TEntity GetById(TId id);
        IEnumerable<TEntity> GetAll();
        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TId id);
    }
}