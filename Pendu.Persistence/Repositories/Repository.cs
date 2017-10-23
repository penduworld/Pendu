using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pendu.Common.Interfaces;
using Pendu.Common.Entities;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace Pendu.Persistence.Repositories
{
    public abstract class Repository<TEntity> : IWriteRepository<TEntity> where TEntity : ModelBase
    {
        protected readonly DbContext Context;
        protected Repository(IUnitOfWork unitOfWork, PenduConnection connection)
        {
            unitOfWork.Register(this);
            Context = connection.AppContext;
        }

        #region Implementaions
        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }
        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().FirstOrDefault(predicate);
        }
        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }
        public void AddOrUpdate(TEntity entity)
        {
            Context.Set<TEntity>().AddOrUpdate(entity);
        }
        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }
        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
        public void Submit()
        {
            Context?.SaveChanges();
        }
        #endregion
    }
}
