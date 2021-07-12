using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3
{
    public class Customer

    {
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }

        //varibles
        public string address;
        public static int currentValueForCustomerId;
        public int customerId;
        public string customerName;
        public DateTime dateOfBirth;
        public string emailId;
        public Enums.Gender gender;
        public string password;

        //enums
        public class Enums
        {
            public enum Gender
            {
                Male, Female, Other
            }  }

            public enum CustomerCardType
            {
                Silver, Gold, Platinum
            }

            //constructors
             static Customer()
            {
                currentValueForCustomerId = 1000;
            }
            public Customer()
            {
                customerId = currentValueForCustomerId;
                currentValueForCustomerId++;
                Console.WriteLine(customerId);
            }

            public Customer(string customerName, string address, DateTime dateOfBirth, string emailId, Enums.Gender gender, string password)
            {
                this.customerName = customerName;
                this.address = address;
                this.dateOfBirth = dateOfBirth;
                this.emailId = emailId;
                this.gender = gender;
                this.password = password;
            }
        }
    }

