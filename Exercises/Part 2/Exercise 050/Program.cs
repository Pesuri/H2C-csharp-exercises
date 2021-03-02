using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("How many times?");
        int numero = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numero; i++)
        {
            PrintPhrase(); 
        }
    }

    public static void PrintPhrase()
    {
        Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}
