using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = GrEatest(2, 7, 3);
      Console.WriteLine("GrEatest: " + answer);
    }

    public static int GrEatest(int number1, int number2, int number3)
    {
        if      (number1 > number2 && number1 > number3){return number1;}
        else if (number2 > number1 && number2 > number3){return number2;}
        else                                            {return number3;}
    }

  }
}
