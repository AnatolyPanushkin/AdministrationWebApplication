using System.Collections;
using System.Collections.Generic;
using AdministrationWebApplication.Models;

namespace AdministrationWebApplication.Data
{
    public interface IPassengerContext
    {
        public IEnumerable<Passenger> GetAllPassenger();
        public Passenger GetAllByTicketNumber(int ticketNumber);
    }
}