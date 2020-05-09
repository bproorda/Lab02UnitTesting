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
            try
            {
                string receipt = "";
                int transactionCounter = 0;
                bool fuse = true;
                while (fuse)
                {
                    Console.WriteLine("Welcome to Your DeltaV ATM! \n Please Select from an Option From Below \n 1. Get Balance \n 2. Withdraw Money \n 3. Add Money \n 4. Exit ");
                    Console.WriteLine();
                    Console.Write("Enter a number for the desired option: ");
                    Console.WriteLine();
                    string optionChosen = Console.ReadLine();
                    switch (optionChosen)
                    {
                        case "1":
                            Console.WriteLine(String.Format("Your current balance is: {0:C2}", GetBalance()));
                            Console.WriteLine();
                            break;
                        case "2":
                            Console.Write("Please enter how much you would like to withdraw: ");
                            double originalBalance = GetBalance();
                            double withdrawThisAmount = Convert.ToDouble(Console.ReadLine());
                            double newBalance = Withdraw(withdrawThisAmount);
                            if (originalBalance != newBalance)
                            {
                                Console.WriteLine(String.Format("Your new balance is: {0:C2}", newBalance));
                                Console.WriteLine();
                                transactionCounter++;
                                receipt += String.Format("Transaction {0}. You withdrew {1:C2}. Resulting Balance: {2:C2} \n", transactionCounter, withdrawThisAmount, newBalance);
                            }
                            else
                            {
                                Console.WriteLine("We apologize, but your transcation was not processed. \n Your account may not fall below $20.00");
                                Console.WriteLine(String.Format("Your current balance is: {0:C2}", GetBalance()));
                                Console.WriteLine();
                            }
                            break;
                        case "3":
                            Console.Write("Please enter how much you would like to add: ");
                            double addThisMuch = Convert.ToDouble(Console.ReadLine());
                            double newBalance2 = AddDeposit(addThisMuch);
                            Console.WriteLine(String.Format("Your new balance is: {0:C2}", newBalance2));
                            Console.WriteLine();
                            transactionCounter++;
                            receipt += String.Format("Transaction {0}. You added {1:C2}. Resulting Balance: {2:C2} \n", transactionCounter, addThisMuch, newBalance2);
                            break;
                        case "4":
                            if (receipt != "")
                            {
                                Console.WriteLine("Here is receipt of your transaction(s)");
                                Console.WriteLine(receipt);
                                Console.WriteLine();
                            }
                            Console.WriteLine("Thank you for using DeltaV ATM. This machine will self-destruct in:");
                            Console.WriteLine("3..");
                            Console.WriteLine("2..");
                            Console.WriteLine("1..");
                            Console.WriteLine("Have a nice day");
                            Console.WriteLine();
                           
                            fuse = false;
                            break;
                        default:
                            Console.WriteLine("Why did you enter an invalid number?");
                            Console.WriteLine();
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error was detected");
            }
        }
        public static double GetBalance()
        {
            
            return Globals.BalanceAmount;
        }
        public static double AddDeposit(double deposit)
        {
            try
            {
                Globals.BalanceAmount += deposit;
                return Globals.BalanceAmount;
            }
            catch (ArgumentException)
            {
                //this needs a returning value to run, what do I use?
                Console.WriteLine("Invalid input please enter a number");
                throw;
                
            }
        }
        public static double Withdraw(double withdrawal)
        {
            try
            {
                if (Globals.BalanceAmount - withdrawal <= 20)
                {
                    return Globals.BalanceAmount;
                }
                else
                {
                    Globals.BalanceAmount -= withdrawal;
                    return Globals.BalanceAmount;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid input please enter a number");
                throw;

               
            }


        }
    }
}
