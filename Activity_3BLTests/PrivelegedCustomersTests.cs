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
    public class PrivelegedCustomersTests
    {
        [TestMethod()]
        public void PrivelegedCustomersTest()
        {
            DateTime a1 = new DateTime(1999, 06, 21);
            PrivelegedCustomers aobj1 = new PrivelegedCustomers("Pranali", "Pune", a1, "pranali@gmail.com",  "pran", Customer.CustomerCardType.Silver);
            DateTime a2 = new DateTime(1995, 08, 31);
            PrivelegedCustomers aobj2 = new PrivelegedCustomers("Prasad", "Delhi", a2, "prasad@gmail.com",  "3108pra", Customer.CustomerCardType.Gold);

            Assert.AreNotSame(a1, a2);
        }
    }
}