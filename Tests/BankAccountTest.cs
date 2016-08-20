using NUnit.Framework;
using SimpleLibrary;
using SimpleLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class BankAccountTest
    {
        [Test]
        public void TransferFunds()
        {
            IBankAccount source = new BankAccount();
            source.Deposit(200m);

            IBankAccount destination = new BankAccount();
            destination.Deposit(150m);

            source.TransferFunds(destination, 100m);

            Assert.AreEqual(250m, destination.GetBalance());
            Assert.AreEqual(100m, source.GetBalance());
        }
    }
}
