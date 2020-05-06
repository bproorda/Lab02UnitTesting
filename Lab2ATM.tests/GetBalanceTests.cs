using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab2ATM.tests
{
   public class GetBalanceTests
    {
        [Fact]
        public void BalanceCheck()
        {
            double result = ATM.GetBalance();
            double expected = Globals.BalanceAmount;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ChangingBalanceCheck()
        {
            double intial = ATM.GetBalance();
            Globals.BalanceAmount += 100;
            double result = ATM.GetBalance();
            double expected = intial + 100;

            Assert.Equal(expected, result);
        }
    }
}
