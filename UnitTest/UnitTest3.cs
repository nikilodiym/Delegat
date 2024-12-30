using delegats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestReplenishAccount()
        {
            Task3.CreditCard card = new Task3.CreditCard();
            card.Balance = 100;
            card.CreditLimit = 1000;
            decimal replenishAmount = 100;
            decimal expectedBalance = card.Balance + replenishAmount;

            card.AccountReplenished += (amount) =>
            {
                Assert.AreEqual(replenishAmount, amount);
                Assert.AreEqual(expectedBalance, card.Balance);
            };

            card.ReplenishAccount(replenishAmount);
        }

        [TestMethod]
        public void TestSpendMoney()
        {
            Task3.CreditCard card = new Task3.CreditCard();
            card.Balance = 100;
            card.CreditLimit = 1000;
            decimal spendAmount = 50;
            decimal expectedBalance = card.Balance - spendAmount;

            card.MoneySpent += (amount) =>
            {
                Assert.AreEqual(spendAmount, amount);
                Assert.AreEqual(expectedBalance, card.Balance);
            };

            card.SpendMoney(spendAmount);
        }

        [TestMethod]
        public void TestStartCredit()
        {
            Task3.CreditCard card = new Task3.CreditCard();
            bool creditStarted = false;

            card.CreditStarted += () =>
            {
                creditStarted = true;
            };

            card.StartCredit();

            Assert.IsTrue(creditStarted);
        }

        [TestMethod]
        public void TestCheckLimit()
        {
            Task3.CreditCard card = new Task3.CreditCard();
            card.Balance = 100;
            card.CreditLimit = 1000;
            decimal checkAmount = 1000;

            card.LimitReached += (amount) =>
            {
                Assert.AreEqual(checkAmount, amount);
            };

            card.CheckLimit(checkAmount);
        }

        [TestMethod]
        public void TestChangePIN()
        {
            Task3.CreditCard card = new Task3.CreditCard();
            string newPIN = "1234";

            card.PINChanged += (pin) =>
            {
                Assert.AreEqual(newPIN, pin);
            };

            card.ChangePIN(newPIN);
        }
    }
}
