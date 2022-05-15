using System.Collections.Generic;
using System.Linq;
using AdministrationWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdministrationWebApplication.Data
{
    public class TicketContext:ITicketContext
    {
        private List<Ticket> _tickets;

        public TicketContext()
        {
            _tickets = new List<Ticket>()
            {
                new Ticket(1111, "Moscow", "Kazan"),
                new Ticket(2222, "Kazan", "Moscow"),
                new Ticket(3333, "Paris","Berlin")
            };
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _tickets.Select(t => t).ToList();
        }

        public Ticket GetTicketByTicketNumber(int ticketNumber)
        {
            return _tickets.FirstOrDefault(t => t.TicketNumber == ticketNumber);
        }
    }
}