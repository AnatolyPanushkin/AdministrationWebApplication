using System.Collections.Generic;
using AdministrationWebApplication.Data;
using AdministrationWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdministrationWebApplication.Controllers
{
    [ApiController]
    public class PassengerController:ControllerBase
    {
        private  readonly IPassengerContext _context;

        public PassengerController(IPassengerContext context)
        {
            _context = context;
        }

        [HttpGet("api/passengers")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Passenger>))]
        [ProducesResponseType(404)]
        public IActionResult GetAllPassengers()
        {
            return Ok(_context.GetAllPassenger());
        }
    }
}