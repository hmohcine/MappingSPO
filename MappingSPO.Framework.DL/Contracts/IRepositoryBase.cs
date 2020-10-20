using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MappingSPO.Framework.DL.Contracts
{
    public interface IRepositoryBase<TEntity> : IDataRepository
        where TEntity : class, new()
    {
        //TEntity Add(TEntity entity);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        TEntity Get(object id);
        //void Remove(object id);
        //void Remove(TEntity entity);
        //TEntity Update(TEntity entity);
        //IEnumerable<TEntity> Update(IEnumerable<TEntity> entities);

        bool IsRecordInUse(object id);

    }
}