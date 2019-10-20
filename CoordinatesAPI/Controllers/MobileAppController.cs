using CoordinatesAPI.Contexts;
using CoordinatesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoordinatesAPI.Controllers
{
    public class MobileAppController : ApiController
    {
        private CoordinatesDbContext _context;
        public MobileAppController()
        {
            _context = new CoordinatesDbContext();
        }

        //GET: api/mobileapp
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new { result = "Mobile App API is Working!" });
        }

        //POST: api/mobileapp
        [HttpPost]
        public IHttpActionResult Post([FromBody]dynamic data)
        {
            AppInfoModel coordinates = new AppInfoModel();
            //coordinates.ID = 1;
            coordinates.Latitude = data.lat;
            coordinates.Longitude = data.longt;
            coordinates.UserId = data.userId;
            _context.Coordinates.Add(coordinates);
            _context.SaveChanges();

            return Ok(new { response = "Data saved! " + data.lat + " and " + data.longt }); //galima grazinti tik man suprantama koda, butu logiskiau.
        }
    }
}
