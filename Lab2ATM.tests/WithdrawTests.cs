using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lab2ATM.tests
{
    public class WithdrawTests
    {
        [Fact]
        public void TakeoutTenTest()
        {
            double input = 10;
            double intial;
            if (Globals.BalanceAmount > 20)
            {
                intial = Globals.BalanceAmount;
            }
            else
            {
                Globals.BalanceAmount += 50;
                intial = Globals.BalanceAmount;
            }
            double result = ATM.Withdraw(input);
            double expected = intial - 10;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void OverdrawnTest()
        {
            Globals.BalanceAmount = 19;
            double intial = Globals.BalanceAmount;
            double result = ATM.Withdraw(1);

            Assert.Equal(result, intial);
        }
    }
}
