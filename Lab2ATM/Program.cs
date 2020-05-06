using System;

namespace Lab2ATM
{
      public class Globals
    {
        public static double BalanceAmount = 0;
    }
   public class ATM
    {  
        static void Main(string[] args)
        {
            Console.WriteLine(GetBalance());
            Console.ReadLine();
        }
        public static double GetBalance()
        {
            
            return Globals.BalanceAmount;
        }
        public static double AddDeposit(double deposit)
        {
            Globals.BalanceAmount += deposit;
            return Globals.BalanceAmount;
        }
        public static double Withdraw(double withdrawal)
        {
            if(Globals.BalanceAmount - withdrawal <= 20)
            {
                return Globals.BalanceAmount;
            } else
            {
                Globals.BalanceAmount -= withdrawal;
                return Globals.BalanceAmount;
            }

        }
    }
}
