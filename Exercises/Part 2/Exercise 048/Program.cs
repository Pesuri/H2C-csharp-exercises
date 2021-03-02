using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
        int numero = 0;
        int summa = 0;
        int laskuri = 0;
        int pariton = 0;
        Console.WriteLine("Give numers:");
        while(numero != -1)
        {
            numero = Convert.ToInt32(Console.ReadLine()); 
            if (numero != -1)
            {
                summa += numero;
                laskuri++;
                if (numero % 2 == 1) {pariton++;}
            }
        }
        double average = summa / (laskuri + 0.0);
        int parillinen = laskuri - pariton;
        Console.WriteLine("Thx! Bye!");
        Console.WriteLine("Sum: " + summa);
        Console.WriteLine("Numbers: " + laskuri);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Even: " + parillinen);
        Console.WriteLine("Odd: " + pariton);

    }
  }
}
