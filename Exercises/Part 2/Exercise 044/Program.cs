using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {
        int numero1 = Convert.ToInt32(Console.ReadLine());
        int numero2 = Convert.ToInt32(Console.ReadLine());
        if      (numero1 > numero2) {Console.WriteLine(numero1 + " is grEater than " + numero2);} //I wonder what is the joke with writing greater as grEater.
        else if (numero1 < numero2) {Console.WriteLine(numero1 + " is less than " + numero2);}
        else                        {Console.WriteLine(numero1 + " is equal to " + numero2);}
        
    }
  }
}
