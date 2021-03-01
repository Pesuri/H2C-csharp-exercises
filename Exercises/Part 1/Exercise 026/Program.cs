using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give your age:");
        int ika = Convert.ToInt32(Console.ReadLine());
        if (ika < 1900) {Console.WriteLine("You are old.");}

    }
  }
}
