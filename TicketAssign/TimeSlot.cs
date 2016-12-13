using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketAssign
{
    class TimeSlot
    {
        public DateTime BeginTime { get; set; }
        public TimeSpan TimeLength { get; set; }
        public int NumberOfTicketsIssued { get; set; }
        public DateTime EndTime { get; set; }
    }

}
