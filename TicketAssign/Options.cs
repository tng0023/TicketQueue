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
    public partial class Options : Form
    {
       
        public Options()
        {
            InitializeComponent();
            SetDefaultOptions();

        }
        public void SetDefaultOptions() //loads default options into window
        {
            Minutes = 5;
            Guests = 5;
            Start = DateTime.Now;
            End = DateTime.Now.AddHours(4);
            FirstTicket = 1;
    }

        public int Minutes { get; set; }
        public int Guests { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int FirstTicket { get; set; }

        private void Options_Load(object sender, EventArgs e) //loads input to options
        {
            txt_firstTicket.Text = FirstTicket.ToString();
            txt_guests.Text = Guests.ToString();
            txt_startTime.Text = Start.ToShortTimeString();
            txt_endTime.Text = End.ToShortTimeString();
            txt_minutes.Text = Minutes.ToString();

        }

        public void btn_confirm_Click(object sender, EventArgs e) //confirm options 
        {
            try       // Catch all the exceptions that will occur
            {
                if (IsValid()) //Doing validation on every single entry
                {
                    
                    FirstTicket = Convert.ToInt32(txt_firstTicket.Text);
                    Guests = Convert.ToInt32(txt_guests.Text);
                    Start = Convert.ToDateTime(txt_startTime.Text);
                    End = Convert.ToDateTime(txt_endTime.Text);
                    Minutes = Convert.ToInt32(txt_minutes.Text);
                    Ticket.SetFirstTicketNumber(FirstTicket);
                    this.Hide();
                    
                }
            }

            catch (FormatException) //Handling format exceptions
            {
                MessageBox.Show(" Formating exception occurs, Please check your entries", "Entry Error");
            }
            catch (OverflowException) //Handling overflow exceptions
            {
                MessageBox.Show(" OverFlow exception occurs, Please enter small value", "Entry Error");
            }
            catch (Exception ex) //Handling any other exceptions that have not be created yet
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }
        public bool IsPresent(TextBox text, string name) //checks if fields are entered
        {
            if (text.Text == "")
            {
                MessageBox.Show(name + " Is a required field. Enter a data", "Entry Error");
                text.Focus();
                return false;
            }
            return true;
        }

        //Method to check if the entry is an integer
        public bool IsInt(TextBox text, string name) //checks for integers
        {
            long num = 0;
            if (Int64.TryParse(text.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " has to be an int, Please enter an integer ", "Entry Error");
                text.Focus();
                return false;
            }
        }
        public bool IsValid() //validator for entries
        {
            return
                IsPresent(txt_minutes, "Minutes") &&    //Validation on minutes, guest, first ticket
                IsPresent(txt_guests, "Guests") &&
                IsPresent(txt_firstTicket, "First Ticket") &&

                IsInt(txt_minutes, "Minutes") &&
                IsInt(txt_guests, "Guests") &&
                IsInt(txt_firstTicket, "First Ticket");
                }
    }
}
