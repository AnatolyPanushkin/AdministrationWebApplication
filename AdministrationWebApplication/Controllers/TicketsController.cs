using System.Collections.Generic;
using AdministrationWebApplication.Data;
using AdministrationWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdministrationWebApplication.Controllers
{
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketContext _context;

        public TicketsController(ITicketContext context)
        {
            _context = context;
        }

        [HttpGet("api/tickets")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Ticket>))]
        [ProducesResponseType(404)]
        public IActionResult GetAllTickets()
        {
            return Ok(_context.GetAllTickets());
        }
    }
}