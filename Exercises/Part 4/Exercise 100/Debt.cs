using System;

namespace exercise_100
{
    class Debt
    {
        public double balance;
        public double interestRate;

        public Debt(double initialBalance, double initialInterestRate)
        {
            this.interestRate = initialInterestRate;
            this.balance = initialBalance;
        }

        public void PrintBalance()
        {
            Console.WriteLine(balance);
        }

        public void WaitOneYear()
        {
            balance = balance * interestRate;
        }
    }
}



