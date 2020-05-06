using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace Lab2ATM.tests
{
    public class AddDepositTest
    {
        [Fact]
        public void Add100Test()
        {
            double input = 100.50;
            double intialAmount = Globals.BalanceAmount;
            double result = ATM.AddDeposit(input);
            double expected = intialAmount + input;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Add0Test()
        {
            double input = 0;
            double intialAmount = Globals.BalanceAmount;
            double result = ATM.AddDeposit(input);

            Assert.Equal(intialAmount, result);
        }
    }
}
