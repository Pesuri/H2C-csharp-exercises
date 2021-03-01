using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give the first string:");
        string vastaus1 = Console.ReadLine();
        Console.WriteLine("Give the second string:");
        string vastaus2 = Console.ReadLine();
        if      (vastaus1 == vastaus2)  {Console.WriteLine("Echo!");}
        else                            {Console.WriteLine("Nope!");}


    }
  }
}
