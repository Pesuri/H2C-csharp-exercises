namespace exercise_133
{
  public class Money
  {

    private int euros;
    private int cents;

    public Money(int euros, int cents)
    {
      if (cents > 99)
      {
        euros = euros + cents / 100;
        cents = cents % 100;
      }

      this.euros = euros;
      this.cents = cents;
    }

    public Money Plus(Money addition)
    {
      Money newMoney = new Money(this.euros, this.cents);
      // create a new Money object that has the correct worth
      newMoney.euros += addition.euros;
      newMoney.cents += addition.cents;
      while(cents >= 100)
      {
        newMoney.cents -= 100;
        newMoney.euros++;
      }

      // return the new Money object
      return newMoney;
    }

    public Money Minus(Money decreaser)
    {
      Money newMoney = new Money(this.euros, this.cents);
      // create a new Money object that has the correct worth
      newMoney.euros -= decreaser.euros;
      newMoney.cents -= decreaser.cents;
      while(cents < 0)
      {
        newMoney.cents += 100;
        newMoney.euros--;
      }

      if(newMoney.euros < 0)
      {
          newMoney.euros = 0;
          newMoney.cents = 0;
      }

      // return the new Money object
      return newMoney;
    }

    public bool LessThan(Money compared)
    {
      double value1 = this.euros + this.cents/100;
      double value2 = compared.euros + compared.cents/100;
      if(value1 < value2) {return true;}
      return false;
    }

    public override string ToString()
    {
      string zero = "";
      if (cents < 10)
      {
        zero = "0";
      }

      return euros + "." + zero + cents + "e";
    }
  }
}
