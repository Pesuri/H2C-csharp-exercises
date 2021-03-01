using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Your speed:");
        int nopeus = Convert.ToInt32(Console.ReadLine());
        if (nopeus > 120) {Console.WriteLine("Speeding!");}
    }
  }
}
