using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3
{
   public class PrivelegedCustomers:Customer
    {
        public CustomerCardType cardType;
        public CustomerCardType CardType { get; set; }
       public PrivelegedCustomers(string customerName, string address, DateTime dateOfBirth, string emailId, string password, CustomerCardType cardType)
        {
            this.cardType =cardType;
        }
    }
}
