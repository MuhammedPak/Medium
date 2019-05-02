using MediumAppMP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MediumAppMP.Core.DataAccess.EntityFramework
{
    public interface IEntityRepository<T> where T : class, IBaseEntity<T>, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);

        void Test();

    }
}
