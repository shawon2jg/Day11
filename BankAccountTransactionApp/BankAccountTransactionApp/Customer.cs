using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTransactionApp
{
    class Customer
    {
        private string accountNumber;
        private string name;
        private double amount;
        double sum = 0;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Customer(string accountNumber, string name):this()
        {
            AccountNumber = accountNumber;
            Name = name;
        }

        public Customer()
        {
            
        }

        public double GivenDeposit(double amount)
        {
            sum += amount;
            return sum;
        }

        public double GetWithdraw(double amount)
        {
            sum -= amount;
            return sum;
        }

        public string GetReport()
        {
            return Name + ", Your Account No is: " + AccountNumber + " & Balance is: " + sum;
        }
    }
}
