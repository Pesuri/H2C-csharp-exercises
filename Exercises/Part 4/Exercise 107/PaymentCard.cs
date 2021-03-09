using System;

namespace exercise_107
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
            balance -= 10.6;
        }

        public void DrinkCoffee()
        {
            balance -= 2;
        }
    }
}



