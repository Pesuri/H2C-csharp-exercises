using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
        while (true)
        {         
            Console.WriteLine("Give a number:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int poweroftwo = numero * numero;
            if      (numero == 0)   {break;}
            else if (numero < 0)    {Console.WriteLine("That is negative");}
            else                    {Console.WriteLine(poweroftwo);}
        } 
    }
  }
}
