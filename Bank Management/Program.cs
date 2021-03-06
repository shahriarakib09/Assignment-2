using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ourBank = new Bank("Developer's Bank", 100);
            bool repeat1 = true;
            Console.WriteLine("Welcome To Our Banking System");

            while (repeat1)
            {
                Console.WriteLine("Open an account");
                Console.WriteLine("Perform transaction on an account");
                Console.WriteLine("Exit the application");
                string value1 = Convert.ToString(Console.ReadLine());

                switch (value1)
                {
                    case "open":
                        Console.WriteLine("Open Saving Account..");
                        Console.WriteLine("Open Checking Account");
                        Console.WriteLine("Exit the application");
                        string valueOpen = Convert.ToString(Console.ReadLine());
                        switch (valueOpen)
                        {
                            case "saving":
                                Console.WriteLine("Enter Account Name");
                                string accountName = Console.ReadLine();
                                Console.WriteLine("Enter Balance:");
                                double balance = Convert.ToDouble(Console.ReadLine());
                                if (balance < 1)
                                {
                                    Console.WriteLine("Invalid Balance");
                                }
                                else
                                {
                                    Console.WriteLine("Enter Address..");

                                    Console.WriteLine("Enter Road Number:");
                                    string roadNo = Console.ReadLine();
                                    Console.WriteLine("Enter House Number:");
                                    string houseNo = Console.ReadLine();
                                    Console.WriteLine("Enter City:");
                                    string city = Console.ReadLine();
                                    Console.WriteLine("Enter Country:");
                                    string country = Console.ReadLine();
                                    Console.WriteLine("Enter Date of Birth :");

                                    Console.WriteLine("Enter Day:");
                                    int dayS = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter Month:");
                                    int monthS = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter Year:");
                                    int yearS = Convert.ToInt32(Console.ReadLine());

                                    Birthday birthS = new Birthday(dayS, monthS, yearS);
                                    Address addressS = new Address(roadNo, houseNo, city, country);
                                    Account account1 = new Account(accountName, balance, addressS, birthS, "saving", 0);
                                    ourBank.AddAccount(account1);
                                    Console.WriteLine("Saving Account Created Successfully");



                                }
                                continue;
                            case "checking":
                                Console.WriteLine("Enter Account Name");
                                string accountNameC = Console.ReadLine();
                                Console.WriteLine("Enter Balance:");
                                double balanceC = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Enter Address..");

                                Console.WriteLine("Enter Road Number:");
                                string roadNoC = Console.ReadLine();
                                Console.WriteLine("Enter House Number:");
                                string houseNoC = Console.ReadLine();
                                Console.WriteLine("Enter City:");
                                string cityC = Console.ReadLine();
                                Console.WriteLine("Enter Country:");
                                string countryC = Console.ReadLine();
                                Console.WriteLine("Enter Date of Birth :");

                                Console.WriteLine("Enter Day:");
                                int dayC = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Month:");
                                int monthC = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Year:");
                                int yearC = Convert.ToInt32(Console.ReadLine());

                                Birthday birthC = new Birthday(dayC, monthC, yearC);
                                Address addressC = new Address(roadNoC, houseNoC, cityC, countryC);
                                Account account2 = new Account(accountNameC, balanceC, addressC, birthC, "Checking", 0);
                                ourBank.AddAccount(account2);
                                Console.WriteLine("Checking Account Created Successfully");

                                continue;
                            case "quit":
                                Console.WriteLine("..Exit..");



                                break;

                        }
                        break;
                    case "account":

                        Console.WriteLine("Make a Deposit");
                        Console.WriteLine("Make a Withdrawal");
                        Console.WriteLine("Make a transfer");
                        Console.WriteLine("Show the number od transaction");
                        Console.WriteLine("Exit the application");
                        string valueAcc = Convert.ToString(Console.ReadLine());
                        switch (valueAcc)
                        {
                            case "deposit":
                                Console.WriteLine("Enter Account NUmber:");
                                int accountDepo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the amount of deposit:");
                                double balanceDepo = Convert.ToDouble(Console.ReadLine());
                                for (int i = 0; i < ourBank.MyBank.Length; i++)
                                {
                                    if (ourBank.MyBank[i].AccountNumber == accountDepo)
                                    {
                                        ourBank.MyBank[i].Deposit(balanceDepo);
                                        ourBank.MyBank[i].numOfTransaction++;
                                        break;
                                    }
                                    else if (ourBank.MyBank[i].AccountNumber != accountDepo)
                                    {
                                        Console.WriteLine("Account number invalid");
                                        break;

                                    }

                                }
                                break;
                            case "withdraw":
                                Console.WriteLine("Enter the Account Number:");
                                int accountWit = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the amount of withdraw:");
                                double balanceWit = Convert.ToDouble(Console.ReadLine());
                                for (int i = 0; i < ourBank.MyBank.Length; i++)
                                {
                                    if (ourBank.MyBank[i].AccountNumber == accountWit)
                                    {
                                        ourBank.MyBank[i].Withdraw(accountWit);
                                        ourBank.MyBank[i].numOfTransaction++;
                                        break;
                                    }
                                    else if (ourBank.MyBank[i].AccountNumber != accountWit)
                                    {
                                        Console.WriteLine("Account number invalid");
                                        break;
                                    }

                                    break;
                                }
                                break;
                            case "transfer":

                               break;

                            case "show":
                                Console.WriteLine("Enter the Account Number:");
                                int accountshow = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < ourBank.MyBank.Length; i++)
                                {
                                    if (ourBank.MyBank[i].AccountNumber == accountshow)
                                    {
                                        Console.WriteLine("Number of trasactions:" + ourBank.MyBank[i].numOfTransaction);
                                        Console.WriteLine("Balance:" + ourBank.MyBank[i].Balance);
                                        break;
                                    }
                                    else if (ourBank.MyBank[i].AccountNumber != accountshow)
                                    {
                                        Console.WriteLine("Account number invalid");
                                        break;

                                    }
                                    break;
                                }
                                break;

                            case "quit":
                                Console.WriteLine("..Exit..");

                                break;

                       }
                        break;
                        //ourBank.PrintAccountDetailes();
                        

                }
            }
        }
    }
}
