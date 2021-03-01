using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
        int laskuri = 0;
        while (true)
        {         
            Console.WriteLine("Give a number:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if      (numero == 0)   {break;}
            else if (numero < 0)    {laskuri += 1;}
        }
        Console.WriteLine("Total amount of negative numbers: " + laskuri);
    }
  }
}
