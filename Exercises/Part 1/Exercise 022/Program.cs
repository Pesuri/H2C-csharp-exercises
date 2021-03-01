using System;

namespace exercise_22
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
        double keskiarvo = (numero1 + numero2 + numero3) / 3.0;
        Console.WriteLine("The average is " + keskiarvo);
    }
  }
}
