using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give the first number!");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give the second number!");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int summa = numero1 + numero2;
        Console.WriteLine("The sum is " + summa);

    }
  }
}
