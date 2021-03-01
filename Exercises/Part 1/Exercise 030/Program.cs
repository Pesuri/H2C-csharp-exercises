using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give your percent [0 - 100]:");
        int prosentti = Convert.ToInt32(Console.ReadLine());
        if      (prosentti < 0)     {Console.WriteLine("Impossible"     );}
        else if (prosentti <= 49)   {Console.WriteLine("Fail"           );}
        else if (prosentti <= 59)   {Console.WriteLine("Grade: 1"       );}
        else if (prosentti <= 69)   {Console.WriteLine("Grade: 2"       );}
        else if (prosentti <= 79)   {Console.WriteLine("Grade: 3"       );}
        else if (prosentti <= 89)   {Console.WriteLine("Grade: 4"       );}
        else if (prosentti <= 100)  {Console.WriteLine("Grade: 5"       );}
        else                        {Console.WriteLine("Outstanding!"   );}
    }
  }
}
