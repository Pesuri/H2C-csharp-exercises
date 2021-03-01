using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a number:");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero < 0) {Console.WriteLine("It is not positive");}
        else            {Console.WriteLine("It is positive");}

    }
  }
}
