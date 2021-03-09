using System;

namespace exercise_109
{
    class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }

        public override string ToString()
        {
            // write code here
            return "The card has a balance of " + balance + " euros";
        }

        public void EatLunch()
        {
            if(balance - 10.6 > 0) { balance -= 10.6; }
        }

        public void DrinkCoffee()
        {
            if(balance - 2 > 0) { balance -= 2; }
        }

        public void AddMoney(double amount)
        {
            // write code here
            if (amount >= 0) { balance += amount; }
            if (balance > 150) { balance = 150; }
            
        }
    }
}



