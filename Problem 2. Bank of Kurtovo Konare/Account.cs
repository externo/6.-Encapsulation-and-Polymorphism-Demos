using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_of_Kurtovo_Konare
{
    abstract class Account: IAccount
    {
        private decimal balance;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        //properties
        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        //methods
        public void Deposit(decimal money)
        {
            this.Balance += money;
        }

        decimal CalculateInterest(int months)
        {
            return this.Balance * (1 + this.InterestRate * months);
        }
    }
}
