using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give the first number!");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give the second number!");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give the third number!");
        int numero3 = Convert.ToInt32(Console.ReadLine());
        int summa = numero1 + numero2 + numero3;
        Console.WriteLine("The sum is " + summa);

    }
  }
}
