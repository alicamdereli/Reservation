using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

        public class ServiceController : Controller
        {
            private readonly IServicesService _ServicesService;

            public ServiceController(IServicesService ServicesService)
            {
                _ServicesService = ServicesService;
            }

            // GET: api/values
            [HttpGet]
            public IActionResult ServicesList()
            {
                var values = _ServicesService.TGetList();
                return Ok(values);
            }

            // POST api/values
            [HttpPost]
            public IActionResult AddServices(Service Services)
            {
                _ServicesService.TInsert(Services);
                return Ok();
            }

            // PUT api/values/5
            [HttpPut]
            public IActionResult UpdateServices(Service Services)
            {
                _ServicesService.TUpdate(Services);
                return Ok();
            }

            // DELETE api/values/5
            [HttpDelete("{id}")]
            public IActionResult DeleteServices(int id)
            {
                var values = _ServicesService.TGetById(id);
                _ServicesService.TDelete(values);
                return Ok();
            }

            // GET: api/values
            [HttpGet("{id}")]
            public IActionResult GetServices(int id)
            {
                var values = _ServicesService.TGetById(id);
                return Ok(values);
            }
        }
    
}

