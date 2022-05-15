using System.Collections.Generic;
using System.Linq;
using AdministrationWebApplication.Models;

namespace AdministrationWebApplication.Data
{
    public class PassengerContext:IPassengerContext
    {
       
        private List<Passenger> _passengers;
        public PassengerContext(ITicketContext ticketContext)
        {

            _passengers = new List<Passenger>()
            {
                new Passenger("Ivan", "Ivanov", 1111),
                new Passenger("Dmitriy", "Fedorov", 2222),
                new Passenger("Jullia", "Roberts", 3333)
            };
        }

        public IEnumerable<Passenger> GetAllPassenger()
        {
            return _passengers.Select(p => p).ToList();
        }

        public Passenger GetAllByTicketNumber(int ticketNumber)
        {
            return _passengers.FirstOrDefault(p => p.TicketNumber == ticketNumber);
        }
    }
}