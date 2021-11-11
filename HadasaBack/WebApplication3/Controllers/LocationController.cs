using MyDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication3.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LocationController : ApiController
    {
        [System.Web.Http.HttpPost]
        public IHttpActionResult SaveCurrentLocation(CurrentLocation curLocation)
        {
            new LocationService().SaveCurrentLocation(curLocation);
            return Ok(new { IsSucceed = true });
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetAllLocations()
        {
            var res=new LocationService().GetAllLocations();
            return Ok(new { data = res });
        }
    }
}