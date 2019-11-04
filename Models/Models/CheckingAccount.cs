using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class CheckingAccount
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        
        public decimal Balance { get; set; }

        public DateTime TimeOfCreation { get; set; }
       // public User User { get; set; }
    }
}
