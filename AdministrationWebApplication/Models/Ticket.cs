using System.ComponentModel.DataAnnotations;

namespace AdministrationWebApplication.Models
{
    public class Ticket
    {
        public Ticket(int ticketNumber, string departTown, string arriveTown)
        {
            TicketNumber = ticketNumber;
            DepartTown = departTown;
            ArriveTown = arriveTown;
        }


        
        
        [Key]
        public int TicketNumber { get; set; }
        
        public string DepartTown { get; set; }
        
        public string ArriveTown { get; set; }
    }
}