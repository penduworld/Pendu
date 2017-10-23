using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pendu.Common;
using Pendu.Persistence;
using Pendu.Persistence.Repositories;
using Pendu.ServiceModel.Shared;

namespace Pendu.ServiceInterface.Shared
{
    public class UserService: ServiceBase
    {
        private readonly UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository(new UnitOfWork(), new PenduConnection());
        }

        #region Service Method
        public UserRequest Any(UserRequest request)
        {
            UserRequest result = null;
            try
            {
                if (request.UserName != null)
                {
                    result = new UserRequest() { UserName = request.UserName };
                }
            }
            catch(Exception ex)
            {
                Log.Debug($"Exception Occured.. {ex.Message}");
                Log.Debug($"Stacktrace for the exception.. {ex.StackTrace}");
            }

            Log.Debug($"result.. {result?.UserName}");

            return result;
        }
        #endregion

    }
}
