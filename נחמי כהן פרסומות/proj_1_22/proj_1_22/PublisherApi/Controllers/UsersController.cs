using DTO;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PublisherApi.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        // GET: api/Users
        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        [Route("addUser")]
        [HttpPost]
        public IHttpActionResult AddUser(UserDto userDto)
        {
            var result = BL.UserBl.AddUser(userDto);
            if(result==null)
                return NotFound();
            return Ok(result);
        }

        [Route("checkUser/{password}/{username}")]
        [HttpGet]
        public IHttpActionResult CheckUser(string password, string username)
        {
            var result = BL.UserBl.CheckUser(username,password);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
