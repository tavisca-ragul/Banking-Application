using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_Application
{
    class AccountMethods
    {

        AccountDetails[] accountDetails = new AccountDetails[10];
        int numberOfAccounts = 5;
        public void setAccountDetails()
        {
            accountDetails[0] = new AccountDetails("Savings", "85673648921", "2018081525684968", "2248", "Ragul Krishnan",
                    "High School Street, Namakkal", "16/06/1997", "7373413841", "rkrishnan@tavisca.com", "987456123", 1500);
            accountDetails[1] = new AccountDetails("Current", "85673238921", "2018012525788921", "2248", "Sathish",
                        "High School Street, Salem", "19/02/1993", "6363413341", "sathish@tavisca.com", "347456123", 1500);
            accountDetails[2] = new AccountDetails("DMAT", "85673643682", "2018081525681527", "2248", "Ramesh",
                        " Street, City", "12/12/1981", "9393419891", "ramesh@tavisca.com", "9874561856", 1500);
            accountDetails[3] = new AccountDetails("Savings", "85673640048", "2018081525600457", "2248", "Suresh",
                        "Street, City", "05/02/1992", "7575489648", "suresh@tavisca.com", "987456123", 1500);
            accountDetails[4] = new AccountDetails("Current", "85673647649", "2018081525687564", "2248", "Rajesh",
                        "Street, City", "12/11/1993", "9898754857", "rajesh@tavisca.com", "987456482", 1500);
        }

        public void createNewAccount()
        {
            int itr;
            if(numberOfAccounts == 10)
            {
                Console.WriteLine("\n\n\tNumber of Accounts for this branch reached the limit, so you can not create account in this branch. Sorry :) \n\n");

                return;
            }
            accountDetails[numberOfAccounts] = new AccountDetails();
            Console.WriteLine("\n\t\tEnter Account Details\n");
            Console.Write("Account Number: ");
            accountDetails[numberOfAccounts].setAccountNo(Console.ReadLine());
            for (itr = 0; itr < numberOfAccounts; itr++)
            {
                if (String.Equals(accountDetails[numberOfAccounts].getAccountNo(), accountDetails[itr].getAccountNo()))
                {
                    Console.WriteLine("\n\t\t Account number already exist\n\n");
                    accountDetails[numberOfAccounts].setAccountNo("");
                    return;
                }
            }
            Console.Write("Account Type: ");
            accountDetails[numberOfAccounts].setAccountType(Console.ReadLine());
            Console.Write("CIFNo: ");
            accountDetails[numberOfAccounts].setCIFNo(Console.ReadLine());
            Console.Write("Customer Name: ");
            accountDetails[numberOfAccounts].setCustomerName(Console.ReadLine());
            Console.Write("IFSC Code: ");
            accountDetails[numberOfAccounts].setIFSCCode(Console.ReadLine());
            Console.Write("Address: ");
            accountDetails[numberOfAccounts].setAddress(Console.ReadLine());
            Console.Write("DOB: ");
            accountDetails[numberOfAccounts].setDOB(Console.ReadLine());
            Console.Write("Phone No: ");
            accountDetails[numberOfAccounts].setPhone(Console.ReadLine());
            Console.Write("Email ID: ");
            accountDetails[numberOfAccounts].setEMailID(Console.ReadLine());
            Console.Write("MICR: ");
            accountDetails[numberOfAccounts].setMICR(Console.ReadLine());
            Console.Write("Initial Deposit: ");
            accountDetails[numberOfAccounts].setBalance(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("\t\t New Account is created \n\n");
            numberOfAccounts++;
        }

        public void displayAccountDetails()
        {
            int itr;
            for(itr = 0; itr < numberOfAccounts; itr++)
            {
                Console.WriteLine("\t\tAccount Details");
                Console.WriteLine("Account Type: "+ accountDetails[itr].getAccountType());
                Console.WriteLine("CIFNo: "+ accountDetails[itr].getCIFNo());
                Console.WriteLine("Account Number: "+ accountDetails[itr].getAccountNo());
                Console.WriteLine("Customer Name: "+ accountDetails[itr].getCustomerName());
                Console.WriteLine("IFSC Code: "+ accountDetails[itr].getIFSCCode());
                Console.WriteLine("Address: "+ accountDetails[itr].getAddress());
                Console.WriteLine("DOB: "+ accountDetails[itr].getDOB());
                Console.WriteLine("Phone No: "+ accountDetails[itr].getPhone());
                Console.WriteLine("Email ID: " + accountDetails[itr].getEMailID());
                Console.WriteLine("MICR: "+ accountDetails[itr].getMICR());
                Console.WriteLine("Balance: " + accountDetails[itr].getBalance() + "\n\n");
            }
        }

        public void searchByAccountNo(String accountNo)
        {
            int itr;
            for(itr = 0; itr < numberOfAccounts; itr++)
            {
                if(String.Equals(accountNo, accountDetails[itr].getAccountNo()))
                {
                    Console.WriteLine("\t\tAccount Details");
                    Console.WriteLine("Account Type: " + accountDetails[itr].getAccountType());
                    Console.WriteLine("CIFNo: " + accountDetails[itr].getCIFNo());
                    Console.WriteLine("Account Number: " + accountDetails[itr].getAccountNo());
                    Console.WriteLine("Customer Name: " + accountDetails[itr].getCustomerName());
                    Console.WriteLine("IFSC Code: " + accountDetails[itr].getIFSCCode());
                    Console.WriteLine("Address: " + accountDetails[itr].getAddress());
                    Console.WriteLine("DOB: " + accountDetails[itr].getDOB());
                    Console.WriteLine("Phone No: " + accountDetails[itr].getPhone());
                    Console.WriteLine("Email ID: " + accountDetails[itr].getEMailID());
                    Console.WriteLine("MICR: " + accountDetails[itr].getMICR());
                    Console.WriteLine("Balance: " + accountDetails[itr].getBalance() + "\n\n");

                    return;
                }
            }
            Console.WriteLine("\n\t\tInValid Account Number\n\n");
        }

        public void deposit(String accountNo, double depositAmount)
        {
            int itr;
            for(itr = 0; itr < numberOfAccounts; itr++)
            {
                if(String.Equals(accountNo, accountDetails[itr].getAccountNo()))
                {
                    accountDetails[itr].setBalance(accountDetails[itr].getBalance() + depositAmount);
                    Console.WriteLine("\t\tUpdated Balance : " + accountDetails[itr].getBalance() + "\n\n");

                    return;
                }
            }
            Console.WriteLine("\n\t\tInValid Account Number\n\n");
        }

        public void withdraw(String accountNo, double withdrawAmount)
        {
            int itr;
            double minimumBalance = 0;
            for (itr = 0; itr < numberOfAccounts; itr++)
            {
                if (String.Equals(accountNo, accountDetails[itr].getAccountNo()))
                {
                    if (String.Equals("Savings", accountDetails[itr].getAccountType()))
                    {
                        minimumBalance = 1000;
                    }
                    else if (String.Equals("Current", accountDetails[itr].getAccountType()))
                    {
                        minimumBalance = 0;
                    }
                    else if (String.Equals("DMAT", accountDetails[itr].getAccountType()))
                    {
                        minimumBalance = -10000;
                    }

                    if(accountDetails[itr].getBalance() - withdrawAmount >= minimumBalance)
                    {
                        accountDetails[itr].setBalance(accountDetails[itr].getBalance() - withdrawAmount);
                        Console.WriteLine("\t\tUpdated Balance : " + accountDetails[itr].getBalance() + "\n\n");
                    } 
                    else
                    {
                        Console.WriteLine("You cannot withdraw entered amount, it goes under Minimum Balance.., Try again with less amount in next transaction..\n\n");
                    }

                    return;
                }
            }
            Console.WriteLine("\n\t\tInValid Account Number\n\n");

        }

        public void calculateInterest(String accountNo)
        {
            int itr;
            for (itr = 0; itr < numberOfAccounts; itr++)
            {
                if (String.Equals(accountNo, accountDetails[itr].getAccountNo()))
                {
                    Console.WriteLine("\t\tBalance : " + accountDetails[itr].getBalance());
                    if (String.Equals("Savings", accountDetails[itr].getAccountType()))
                    {
                        Console.WriteLine("\t\tInterest : " + (accountDetails[itr].getBalance() * 4) / 100 + "\n\n");
                    }
                    else if (String.Equals("Current", accountDetails[itr].getAccountType()))
                    {
                        Console.WriteLine("\t\tInterest : " + accountDetails[itr].getBalance() / 100 + "\n\n");
                    }
                    else
                    {
                        Console.WriteLine("\n\t\tThere is no interest for DMAT Accounts\n\n");
                    }

                    return;
                }
            }
            Console.WriteLine("\n\t\tInValid Account Number\n\n");
        }
    }
}
