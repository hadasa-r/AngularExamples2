using MyDal;
using MyDal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]//http://localhost:4200

    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }
         
        public IHttpActionResult GetCurrentTime()
        {
          
            return Ok(DateTime.Now);
        }
        //[EnableCors(origins: "*", headers: "*", methods: "*")]
        [System.Web.Http.HttpPost]
        public IHttpActionResult SaveHeara(Person p)
        {
            new LocationService().SavePerson(p);
            return Ok(new { IsSucceed=true});
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
