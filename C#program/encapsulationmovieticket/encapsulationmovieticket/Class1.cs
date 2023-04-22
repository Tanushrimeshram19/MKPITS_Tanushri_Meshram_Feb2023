using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationmovieticket
{
    internal class Class1
    {
        private string moviename;
        private string Theatername;
        private int Showtime;
        private int Seatnumber;
        private int Ticketprice;
        public string onlineticket
        {
            get { return moviename; }
            set { moviename = value; }
        }
        public string Theaternane
        {
            get { return Theatername; }
            set { Theatername = value; }
        }
        public string showtime
        {
            get { return showtime; }
            set { showtime = value; }
        }
        public int seatnumber
        {
            get { return seatnumber; }
            set { seatnumber = value; }
        }
        public int ticketprice
        {
            get { return ticketprice; }
            set { ticketprice = value; }

        }
    }
}
         class program
       {
    public static void Main(string[] args)
    {
        Movieticket m = new Movieticket();
        m.moviename= "Pathaan\r\nBaahubali 2 The Conclu\r\nKGF Chapter 2;"
        m.Theatername= "Cinemax Cinemas (Eternity Mall)\r\nK Sera Sera Miniplex\r\nAlankar Cinema\r\nGoyal Talkies.\r\nINOX Cinemas (Jaswant Tuli Mall);"
        m.showtime= 
    }

    

}

