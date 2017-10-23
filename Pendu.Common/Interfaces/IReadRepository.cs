using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Pendu.Common.Entities;

namespace Pendu.Common.Interfaces
{
    public interface IReadRepository<TEntity> where TEntity : ModelBase
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
    }
}
