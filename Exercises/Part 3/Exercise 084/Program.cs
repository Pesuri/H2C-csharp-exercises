using System;
using System.Collections.Generic;

namespace exercise_84
{
  class Program
  {
    public static void Main(string[] args)
    {
        string input = "";
        while(input != "true")
        {
            Console.Write("Give a string: ");
            input = Console.ReadLine();
            if(input != "true"){Console.WriteLine("Try again!");}
        }
        Console.WriteLine("You got it right!");
    }
  }
}

