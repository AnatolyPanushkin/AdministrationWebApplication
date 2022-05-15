using System.ComponentModel.DataAnnotations;

namespace AdministrationWebApplication.Models
{
    public class Passenger
    {
        public Passenger(string firstName, string lastName, int ticketNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            TicketNumber = ticketNumber;
        }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        [Key]
        public int TicketNumber { get; set; }
    }
}