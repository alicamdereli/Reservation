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
    public class StaffController : Controller
    {
        private readonly IStaffService _stafService;

        public StaffController(IStaffService stafService)
        {
            _stafService = stafService;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _stafService.TGetList();
            return Ok(values);
        }

        // POST api/values
        [HttpPost]
        public IActionResult AddStaff(Staff staff )
        {
            _stafService.TInsert(staff);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _stafService.TUpdate(staff);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var values = _stafService.TGetById(id);
            _stafService.TDelete(values);
            return Ok();
        }

        // GET: api/values
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _stafService.TGetById(id);
            return Ok(values);
        }
    }
}

