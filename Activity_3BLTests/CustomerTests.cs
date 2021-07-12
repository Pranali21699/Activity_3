using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CustomerTest()
        {
            DateTime a1 = new DateTime(1999, 06, 21);
            EliteCustomer aobj1 = new EliteCustomer("Pranali", "Pune", a1, "pranali@gmail.com", Customer.Enums.Gender.Female, "pran", 100);
            DateTime a2 = new DateTime(1995, 08, 31);
            EliteCustomer aobj2 = new EliteCustomer("Prasad", "Delhi", a2, "prasad@gmail.com", Customer.Enums.Gender.Male, "3108pra", 200);

            Assert.AreNotSame(a1, a2);
        }
    }
}