using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Pendu.Common.Interfaces;
using Pendu.Entities.Models;
using Pendu.Interfaces;
using Pendu.Persistence.Data;

namespace Pendu.Persistence.Repositories
{
    public class UserRepository : Repository<Entities.Models.PenduUser>, IUserRepository
    {
        public PenduDbContext penduDbContext
        {
            get { return Context as PenduDbContext; }
        }

        public UserRepository(IUnitOfWork unitOfWork, PenduConnection connection) : base(unitOfWork, connection) { }

        #region Implementations
        public Entities.Models.PenduUser GetPenduUser(string UserName)
        {
            var User = (from u in penduDbContext.PenduUsers
                        where u.UserName.Equals(UserName, StringComparison.OrdinalIgnoreCase)
                        select u).SingleOrDefault();
            return User;
        }
        public IEnumerable<PenduUser> GetPenduUserList(string userName)
        {
            var UserList = penduDbContext.PenduUsers.Where(t => t.UserName == userName).ToList();          

            return UserList;
        }
        #endregion
    }
}
