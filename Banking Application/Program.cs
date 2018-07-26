using System;

using System.IO;

namespace Banking_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountMethods accountMethods = new AccountMethods();
            accountMethods.setAccountDetails();
            String accountNo;
            double depositAmount, withdrawAmount;
            userInput:
            Console.Write("1.New Account\n2.Display Account Details\n3.Search by Account No\n4.Deposit\n5.Withdraw\n6.Calculate Interest\n7.Exit\nEnter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1: accountMethods.createNewAccount();
                    goto userInput;
                case 2: accountMethods.displayAccountDetails();
                    goto userInput;
                case 3:
                    Console.Write("Account Number: ");
                    accountNo = Console.ReadLine();
                    accountMethods.searchByAccountNo(accountNo);
                    goto userInput;
                case 4:
                    Console.Write("Account Number: ");
                    accountNo = Console.ReadLine();
                    Console.Write("Deposit Amount: ");
                    depositAmount = Convert.ToDouble(Console.ReadLine());
                    accountMethods.deposit(accountNo, depositAmount);
                    goto userInput;
                case 5:
                    Console.Write("Account Number: ");
                    accountNo = Console.ReadLine();
                    Console.Write("Withdraw Amount: ");
                    withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    accountMethods.withdraw(accountNo, withdrawAmount);
                    goto userInput;
                case 6:
                    Console.Write("Account Number: ");
                    accountNo = Console.ReadLine();
                    accountMethods.calculateInterest(accountNo);
                    goto userInput;
                case 7:
                    return;
                default: Console.WriteLine("Invalid Choice, try again");
                    goto userInput;
            }
            Console.ReadKey();
        }
    }
}
