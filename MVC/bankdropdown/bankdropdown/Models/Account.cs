namespace bankdropdown.Models
{
    public class Account
    {
        public int Accountno { get; set; }
        public int Ammount { get; set; }
        public transtype gettranstype { set; get; }
    }
      public enum transtype
     {
        Deposit ,Withdrawl

    }

    }

