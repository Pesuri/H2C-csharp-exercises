using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("How old are you?");
        int ika = Convert.ToInt32(Console.ReadLine());
        if (ika >= 18) {Console.WriteLine("You are adult!");}
        else            {Console.WriteLine("You are under age!");}
    }
  }
}
