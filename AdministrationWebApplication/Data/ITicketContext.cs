using System.Collections.Generic;
using AdministrationWebApplication.Models;

namespace AdministrationWebApplication.Data
{
    public interface ITicketContext
    {
        public IEnumerable<Ticket> GetAllTickets();
        public Ticket GetTicketByTicketNumber(int ticketNumber);
    }
}