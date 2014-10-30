using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAppinheritance;
using NUnit.Framework;

namespace BankingAppTest
{
    [TestFixture]
    public class BankingAppTestClass
    {
        [Test]
        public void Check_Account_integer_deposite_mathod()
        {
            Account account=new Account();
            Assert.AreEqual(true,account.Deposite(122));
        }
        [Test]
        public void Check_Account_double_deposite_mathod()
        {
            Account account = new Account();
            Assert.AreEqual(true, account.Deposite(122.2));
        }
        [Test]
        public void Check_Account_Negative_deposite_mathod()
        {
            Account account = new Account();
            Assert.AreEqual(false, account.Deposite(-122));
        }
        
    }
}
