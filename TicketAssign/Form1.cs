using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketAssign
{
    public partial class Form1 : Form
    {
        Queue<TimeSlot> TimeSlots;
        Queue<Ticket> Tickets;
        Options options;

        int ticketNumber = 0;
        public Form1()
        {
            InitializeComponent();
            TimeSlots = new Queue<TimeSlot>();
            Tickets = new Queue<Ticket>();
            options = new Options();

        }
        private void timer_Tick(object sender, EventArgs e) //Timer for timeslots and labels
        {
            DateTime currentDateTime = DateTime.Now;

            if (currentDateTime < options.Start || currentDateTime > options.End)
            {
                this.Text = "Closed";
            }
            else
            {
                this.Text = "Open";
            }
            this.Text = DateTime.Now.ToLongTimeString() + "(" + this.Text + ")";
            UpdateTotalTicketsOutstanding();
            UpdateNextAvailableEntry();
            UpdateTicketQueue();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            options.ShowDialog();
            lbl_guestsAvail.Text = "No Entry";
            timer.Enabled = true;
            timer.Start();
            InitializeTimeSlots();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_options_Click(object sender, EventArgs e) //options button to clear all entries and enter new options
        {
            DialogResult result = MessageBox.Show("Are you sure you want to restart?\n"
             ,"Restart?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                lst_nextTicket.Items.Clear();
                label3.Text = ticketNumber.ToString();
                lbl_available.Text = " ";
                Options options = new Options();
                options.ShowDialog();
                timer.Enabled = true;
                timer.Start();
                InitializeTimeSlots();
            }

        }

        private void InitializeTimeSlots() //initialize time slots for what is entered into options
        {
            var numSlots = Math.Abs((options.End - options.Start).TotalMinutes / options.Minutes);
            for (int i = 0; i < numSlots; i++)
            {
                var timeSlot = new TimeSlot();
                timeSlot.NumberOfTicketsIssued = 0;
                timeSlot.BeginTime = options.Start.AddMinutes(options.Minutes * i);
                timeSlot.EndTime = timeSlot.BeginTime.AddMinutes(options.Minutes);
                timeSlot.TimeLength = options.End - options.Start;
                TimeSlots.Enqueue(timeSlot);
            }
        }

        //on each ticket issued, need to check how many are left and if timeslot is still open
        private void btn_issueTicket_Click(object sender, EventArgs e) //method to issue tickets into listbox
        {
            var ticket = new Ticket(GetNextTimeSlot());
            Tickets.Enqueue(ticket);
            lst_nextTicket.Items.Add(ticket);
            label3.Text = Tickets.Count.ToString();
            UpdateNextAvailableEntry();
        }

        private TimeSlot GetNextTimeSlot() //method to gather time slots
        {
            foreach (var timeSlot in TimeSlots)
            {
                if (timeSlot.NumberOfTicketsIssued < options.Guests && timeSlot.EndTime > DateTime.Now)
                {
                    timeSlot.NumberOfTicketsIssued++;
                    return timeSlot;
                }
            }
            return null;
        }
        private void UpdateTotalTicketsOutstanding() //method to update total tickets outstanding
        {
            foreach (var ticket in Tickets)
            {
                if (ticket.TicketTimeSlot.EndTime < DateTime.Now)
                {
                    Tickets.Dequeue();
                    lst_nextTicket.Items.Remove(ticket);
                }
            }
            label3.Text = Tickets.Count.ToString();
        }
        private void UpdateNextAvailableEntry() //method to update time for next available entry
        {
            foreach (var timeslot in TimeSlots)
            {
                if (timeslot.NumberOfTicketsIssued < options.Guests && timeslot.EndTime > DateTime.Now)
                {
                    lbl_available.Text = timeslot.BeginTime.ToShortTimeString();
                    break;
                }
            }
        }
        private void UpdateTicketQueue() //method to update the list of outstanding tickets
        {
            if (TimeSlots.Peek().BeginTime <= DateTime.Now)
            {
                TimeSlot readtyTimeSlot = TimeSlots.Dequeue();

                // The loops below check and remove the ticket for the next time slot that is available.
                //If the loops can't find the next timeslot, the loops should break noting the timeslot is not avaiable.
                List<Ticket> ticketsReadyToEnter = new List<Ticket>();
                while (true)
                {
                    if (Tickets.Count > 0 && Tickets.Peek().TicketTimeSlot == readtyTimeSlot)
                    {
                        ticketsReadyToEnter.Add(Tickets.Dequeue());
                    }
                    else
                    {
                        break;
                    }
                }
                lst_nextTicket.Items.Clear();
                lst_nextTicket.Items.AddRange(Tickets.ToArray());

                // If ticket is ready to enter is equal to 1 set the ticket ready to enter to the specific values.
                string ticketsReadyToEnterString = "Not Ready";
                if (ticketsReadyToEnter.Count == 1)
                {
                    ticketsReadyToEnterString = ticketsReadyToEnter[0].TicketNumber.ToString();
                }
                else if (ticketsReadyToEnter.Count == 2)
                {
                    string first = ticketsReadyToEnter[0].TicketNumber.ToString();
                    string second = ticketsReadyToEnter[1].TicketNumber.ToString();
                    ticketsReadyToEnterString = first + " & " + second;
                }
                else if (ticketsReadyToEnter.Count > 2)
                {
                    string first = ticketsReadyToEnter[0].TicketNumber.ToString();
                    string last = ticketsReadyToEnter[ticketsReadyToEnter.Count - 1].TicketNumber.ToString();
                    ticketsReadyToEnterString = first + " - " + last;
                }
                lbl_guestsAvail.Text = ticketsReadyToEnterString;
            }
        }
    }
}
 