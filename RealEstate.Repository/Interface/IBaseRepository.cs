using System.Collections.Generic;

namespace RealEstate.Repository.Interface
{
    public interface IBaseRepository<TEntity, TId>
        where TEntity : class
        where TId : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(TId id);
        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TId id);
    }
}
