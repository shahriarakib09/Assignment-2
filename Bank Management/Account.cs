using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management
{
    class Account
    {
        private int accountNumber;
        private static int count = 1;
        private string accountName;
        private Double balance;
        private Address address;
        private Birthday birthday;
        private string accountType;
        public int numOfTransaction;


        public Account(string accountName, double balance, Address address, Birthday birthday, string accountType, int numOfTransaction)
        {
            accountNumber = count;
            count++;
            this.AccountName = accountName;
            this.Balance = balance;
            this.Address = address;
            this.birthday = birthday;
            this.accountType = accountType;
            this.numOfTransaction = numOfTransaction;
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }


        public String AccountName
        {
            set { this.accountName = value; }
            get
            {
                return accountName;
            }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public Birthday Birthday
        {
            set { this.birthday = value; }
            get { return this.birthday; }
        }
        public string AccountType
        {
            set { this.accountType = value; }
            get { return this.accountType; }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                this.Balance = this.Balance - amount;
                Console.WriteLine("Withdraw successful");

            }
            else
            {
                Console.WriteLine("Insufficiant Balance");
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Previous Balance" + balance);
                Console.WriteLine("Deposit Balance" + amount);
                balance = balance + amount;
                Console.WriteLine("Current Balance" + balance);
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }
            public void Transfer(double amount,Account receiver)
            {
                if(amount>0 && amount<=this.balance)
                {
                    this.balance = this.balance - amount;
                    receiver.balance = receiver.balance + amount;

                }
                else
                {
                    Console.WriteLine("Can not transfer");
                }
            }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}\nAddress{3}\nDate of Birth{4", this.accountNumber, this.accountName, this.balance,this.address.GetAddress(),this.birthday.GetDate());
            
        }
        
    }
    
}

