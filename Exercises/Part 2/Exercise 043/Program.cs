using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero < 0){numero = numero * -1;}
        Console.WriteLine(numero);
    }
  }
}
