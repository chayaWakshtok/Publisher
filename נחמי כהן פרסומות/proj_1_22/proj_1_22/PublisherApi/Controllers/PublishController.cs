using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PublisherApi.Controllers
{
    [RoutePrefix("api/Publish")]
    public class PublishController : ApiController
    {
        // GET: api/Publish
        [Route("getAll")]
        public List<PublishDto> Get()
        {
            return BL.PublishBl.GetPublishAll();
        }

        [Route("getByCompanyId/{id}")]

        public List<PublishDto> GetByCompanyId(int id)
        {
            return BL.PublishBl.GetPublishByCompany(id);
        }

        // GET: api/Publish/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Publish
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Publish/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Publish/5
        public void Delete(int id)
        {
        }
    }
}
