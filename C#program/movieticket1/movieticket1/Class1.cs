using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieticket1
{
    internal class Class1
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
            public float discount { get; set; }
            public override string Calculate_Ticket_Price()
            {
                float tp = No_Of_Seats * Ticket_Price + discount;

                return "Total Price : " + tp.ToString();

            }

        }

        class BoxOffice : Movie_Ticket
        {
            public float Booking_Amount { get; set; }
            public override string Calculate_Ticket_Price()
            {
                float tp = No_Of_Seats * Ticket_Price + Booking_Amount;

                return "Total Price : " + tp.ToString();

            }

        }
    }
}
