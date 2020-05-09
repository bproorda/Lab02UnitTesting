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
            //Console.WriteLine(GetBalance());
            //Console.ReadLine();
            ShowMenu();
        }

        public static void ShowMenu()
        {
            bool fuse = true;
            while(fuse)
            {
                Console.WriteLine("Welcome to Your DeltaV ATM! \n Please Select from an Option From Below \n 1. Get Balance \n 2. Withdraw Money \n 3. Add Money \n 4. Exit ");
                Console.Write("Enter an number for the desired option: ");
                string optionChosen = Console.ReadLine();
                switch (optionChosen)
                {
                    case "4":
                        Console.WriteLine("Thank you for using DeltaV ATM. This machine will self-destruct in");
                        Console.WriteLine("3..");
                        Console.WriteLine("2..");
                        Console.WriteLine("1..");
                        Console.WriteLine("Have a nice day");
                        fuse = false;
                        break;
                    default:
                        Console.WriteLine("Why?");
                        break;
                }
            }
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
