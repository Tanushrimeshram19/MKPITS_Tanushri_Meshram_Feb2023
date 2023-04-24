using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieticket1
{
    abstract class Movie_Ticket
    {
        public string Movie_Name { get; set; }
        public string Theatre_Name { get; set; }
        public string Show_Time { get; set; }
        public int No_Of_Seats { get; set; }

        public float Ticket_Price { get; set; }

        public abstract string Calculate_Ticket_Price();

    }

    class Online_Booking : Movie_Ticket
    {

        public Online_Booking(string Movie_Name, string Theatre_Name, string Show_Time, int No_Of_Seat, int Ticket_Price)
        {
            this.Movie_Name = Movie_Name;
            this.Theatre_Name = Theatre_Name;
            this.Show_Time = Show_Time;
            this.No_Of_Seats = No_Of_Seat;
            this.Ticket_Price = Ticket_Price;
        }
        public float discount { get; set; }
        public override string Calculate_Ticket_Price()
        {
            discount = 0.1f;
            float tp = No_Of_Seats * Ticket_Price + discount;

            return "Total Price : " + tp.ToString();

        }

    }

    class BoxOffice : Movie_Ticket
    {

        public BoxOffice(string Movie_Name, string Theatre_Name, string Show_Time, int No_Of_Seat, int Ticket_Price)
        {
            this.Movie_Name = Movie_Name;
            this.Theatre_Name = Theatre_Name;
            this.Show_Time = Show_Time;
            this.No_Of_Seats = No_Of_Seat;
            this.Ticket_Price = Ticket_Price;
        }
        public float Booking_Amount { get; set; }
        public override string Calculate_Ticket_Price()
        {
            Booking_Amount = 20;
            float tp = No_Of_Seats * Ticket_Price + Booking_Amount;

            return "Total Price : " + tp.ToString();

        }

    }
   
}
