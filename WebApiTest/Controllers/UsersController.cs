using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class UsersController : ApiController
    {
        static List<User> _users = new List<User>()
        {

            new User(){id=1,UserName="Abhishek",Email="send2abhishek@live.com",Phone="9583161631"},
            new User(){id=2,UserName="Aryan",Email="abhishek@live.com",Phone="9583161631"},
        };

        public IEnumerable<User> Get()
        {

            return _users;
        }

        public IHttpActionResult Post([FromBody]User user)
        {

            if (ModelState.IsValid)
            {
                _users.Add(user);
                return Ok();
            }

            return BadRequest(ModelState);
           
        }


    }
}
