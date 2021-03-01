using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a number:");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 1) {Console.WriteLine("It is odd.");}
        else                {Console.WriteLine("It is even.");}
    }
  }
}
