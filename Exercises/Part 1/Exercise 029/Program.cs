using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give the first number!");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give the second number!");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        if (numero1 > numero2)      {Console.WriteLine("The larger number is " + numero1 + "!");}
        else if (numero1 < numero2) {Console.WriteLine("The larger number is " + numero2 + "!");}
        else                        {Console.WriteLine("They are equal!");}
    }
  }
}
