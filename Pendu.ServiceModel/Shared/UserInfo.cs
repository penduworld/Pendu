using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Pendu.ServiceModel.Shared
{
    [Route("/User")]
    [Route("/User/{UserName}","GET")]
    public class UserRequest : IReturn<UserResponse>
    {
        public string UserName { get; set; } 
    }

    public class UserResponse
    {
        public string UserName { get; set; }
    }
}
