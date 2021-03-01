using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Speak, friend, and enter!"); //Nice Lord of the Rings reference.
        string vastaus = Console.ReadLine();
        if (vastaus == "Mellon")    {Console.WriteLine("Welcome, friend");}
        else                        {Console.WriteLine("They've got a cave troll!");}
    }
  }
}
