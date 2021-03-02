using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        double squareroot = Math.Sqrt(number1 + number2);
        Console.WriteLine(squareroot);
    }
  }
}
