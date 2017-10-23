using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pendu.Common.Interfaces;

namespace Pendu.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Dictionary<string, IRepository> _repositories;
        public UnitOfWork()
        {
            _repositories = new Dictionary<string, IRepository>();
        }

        public void Register(IRepository repository)
        {
            _repositories.Add(repository.GetType().Name, repository);
        }
        public void Complete()
        {
            _repositories.ToList().ForEach(x => x.Value.Submit());
        }

        public void Dispose()
        {
            Complete();
        }
    }
}
