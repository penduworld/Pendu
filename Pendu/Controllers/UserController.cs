using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.UI.WebControls;
using Pendu.Common;
using Pendu.Entities.Models;
using Pendu.Persistence;
using Pendu.Persistence.Repositories;
namespace Pendu.Controllers
{
    public class UserController : ApiController
    {
        private UserRepository _userRepository;
        [HttpGet]
        [Route("user/{userName}")]
        public IEnumerable<PenduUser> getUserInfo(string UserName)
        {           
            _userRepository = new UserRepository(new UnitOfWork(), new PenduConnection());
            var users = _userRepository.GetPenduUserList(UserName);
            if (users == null || !users.Any())
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return users.ToList();
        }

        //public HttpResponseMessage Get()
        //{
        //    _userRepository = new UserRepository(new UnitOfWork(), new PenduConnection());
        //    // Get a list of products from a database.
        //    IEnumerable<PenduUser> users = _userRepository.GetAll();

        //    // Write the list to the response body.
        //    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, users);
        //    return response;
        //}

        [HttpGet]
        [Route("alluser/{userName}")]
        public IHttpActionResult getUserList(string UserName)  // I m getting value here.
        {
            _userRepository = new UserRepository(new UnitOfWork(), new PenduConnection());
            var users = _userRepository.GetAll();
            if (users == null || !users.Any())
            {
                return NotFound();
            }
            return Ok(users);
        }


    }
}
