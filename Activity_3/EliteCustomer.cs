using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3
{
   public class EliteCustomer:Customer
    {
        public int ownedCoupons;
        public int OwnedCoupons {
            get 
            { 
                return ownedCoupons; 
            } 
            set { 
                ownedCoupons = value; 
            }
        }
        public EliteCustomer(string customerName, string address, DateTime dateOfBirth, string emailId, Enums.Gender gender, string password, int ownedCoupon)
        {
            OwnedCoupons = this.ownedCoupons;
            if (OwnedCoupons > 0)
            {
                OwnedCoupons = 100;
            }
            else
            {
                Console.WriteLine(" Value entered is not valid!!");
            }
        }
    }
}
