using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketAssign
{
    class Ticket
    {
        private static int nextAvailableTicket;
        public Ticket(TimeSlot nextTimeSlot) //Adds tickets to timeslots
        {
            this.TicketNumber = nextAvailableTicket;
            nextAvailableTicket++;
            this.TicketTimeSlot = nextTimeSlot;
        }
        
        public static void SetFirstTicketNumber(int ticketNumber) //sets first ticket number available
        {
            nextAvailableTicket = ticketNumber;
        }

        public override string ToString() //string to appear within listbox
        {
            return "Ticket" + TicketNumber + " " + TicketTimeSlot.BeginTime.ToShortTimeString();
        }
        public int TicketNumber { get; set; }
        public TimeSlot TicketTimeSlot { get; set; }
    }
}
