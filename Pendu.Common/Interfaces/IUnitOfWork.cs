﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu.Common.Interfaces
{
 
    public interface IUnitOfWork : IDisposable
    {
        void Register(IRepository repository);
        void Complete();
    }
}
