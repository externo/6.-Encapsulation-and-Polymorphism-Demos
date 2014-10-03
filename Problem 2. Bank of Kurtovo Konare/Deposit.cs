using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_of_Kurtovo_Konare
{
    class Deposit: Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) { }

        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }

        public void Deposit(decimal money)
        {
            this.Balance += money;
        }

        decimal CalculateInterest(decimal money, decimal interestRate, int months)
        {
            return money * (1 + interestRate * months);
        }

        public void Withdraw(decimal money)
        {
            this.Balance -= money;
        }
    }
}
