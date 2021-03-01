using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a string:");
        string  mjono = Console.ReadLine();
        Console.WriteLine("Give a integer:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give a double:");
        double numberd = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Give a boolean:");
        Boolean truth = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Your string: " + mjono);
        Console.WriteLine("Your integer: " + number);
        Console.WriteLine("Your double: " + numberd);
        Console.WriteLine("Your boolean: " + truth);

    }
  }
}
