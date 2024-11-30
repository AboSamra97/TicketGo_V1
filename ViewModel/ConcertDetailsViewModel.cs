using MovieTickets.Models;
using System.Collections.Generic;

namespace MovieTickets.ViewModel
{
    public class ConcertDetailsViewModel
    {

        public Concert Concert { get; set; }
        public List<TicketType> TicketTypes { get; set; }


    }

}
