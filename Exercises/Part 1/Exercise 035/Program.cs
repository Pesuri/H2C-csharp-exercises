using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
        while (true)
        {         
            Console.WriteLine("Give a number:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 42) {break;}
        } 
    }
  }
}
