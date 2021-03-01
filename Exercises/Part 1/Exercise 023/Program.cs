using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give the first number!");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give the second number!");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int summa = numero1 + numero2;
        int erotus = numero1 - numero2;
        int tulo = numero1 * numero2;
        double jako = numero1 / (numero2 + 0.0);
        Console.WriteLine(numero1 + " + " + numero2 + " = " + summa);
        Console.WriteLine(numero1 + " - " + numero2 + " = " + erotus);
        Console.WriteLine(numero1 + " * " + numero2 + " = " + tulo);
        Console.WriteLine(numero1 + " / " + numero2 + " = " + jako);
    }
  }
}
