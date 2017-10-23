using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu.Common.Interfaces
{
    public interface IEntityMapper<in TFEntity, out TTEntity>
    {
        TTEntity MapEntity(TFEntity efModel);
    }
}
