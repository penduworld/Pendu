using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pendu.Interfaces;
using Pendu.Entities.Models;
using Pendu.Common.Interfaces;

namespace Pendu.Interfaces
{
    public interface IUserRepository : IWriteRepository<PenduUser>
    {
        PenduUser GetPenduUser(string userName);

        IEnumerable<PenduUser> GetPenduUserList(string userName);
    }
}
