using MediumAppMP.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MediumAppMP.Core.DataAccess.EntityFramework
{
    public class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class, IBaseEntity<TEntity>, new()
    {
        private DbContext db = null;

        public EntityRepository(DbContext _db)
        {
            db = _db;
        }

        public bool Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);

            return db.SaveChanges() > 0;
        }

        public bool Delete(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);

            return db.SaveChanges() > 0;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return db.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? db.Set<TEntity>().ToList() :
                db.Set<TEntity>().Where(filter).ToList();
        }

        public bool Update(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);

            return db.SaveChanges() > 0;
        }
    }
}
