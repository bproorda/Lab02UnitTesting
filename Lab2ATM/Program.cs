using System;

namespace Lab2ATM
{
      public class Globals
    {
        public static decimal BalanceAmount = 0;
    }
    class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine(GetBalance());
            Console.ReadLine();
        }
        public static string GetBalance()
        {
            string message = String.Format("Your current balance = {0:C2}", Globals.BalanceAmount);
            return message;
        }
    }
}
