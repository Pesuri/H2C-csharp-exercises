using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("How many days?");
        int days = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(days * 24 * 60 * 60);
    }
  }
}
