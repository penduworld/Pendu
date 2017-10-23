using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pendu.Common.Entities;

namespace Pendu.Common.Interfaces
{
    public interface IWriteRepository<TEntity> : IReadRepository<TEntity>, IRepository where TEntity : ModelBase
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entites);
        void AddOrUpdate(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entites);
    }
}
