using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
        int summa = 0;
        while (true)
        {         
            Console.WriteLine("Give a number:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if      (numero == 0)   {break;}
            else                    {summa += numero;}
        }
        Console.WriteLine("Total sum of numbers: " + summa); 
    }
  }
}
