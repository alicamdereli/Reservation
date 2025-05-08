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
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonilaService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonilaService = testimonialService;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonilaService.TGetList();
            return Ok(values);
        }

        // POST api/values
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonilaService.TInsert(testimonial);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonilaService.TUpdate(testimonial);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonilaService.TGetById(id);
            _testimonilaService.TDelete(values);
            return Ok();
        }

        // GET: api/values
        [HttpGet("{id}")]
        public IActionResult GetSTestimonial(int id)
        {
            var values = _testimonilaService.TGetById(id);
            return Ok(values);
        }
    }
}

