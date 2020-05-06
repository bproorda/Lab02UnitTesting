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
    }
}
