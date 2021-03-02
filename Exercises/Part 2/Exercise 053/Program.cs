using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
        Division(1, 2);
    }

    public static void Division(int numerator, int denominator)
    {
        double division = numerator / (denominator + 0.0);
        Console.WriteLine(division);
    }

  }
}
