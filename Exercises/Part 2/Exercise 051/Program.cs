using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
        PrintUntilNumber(-3);
    }

    public static void PrintUntilNumber(int number)
    {
        if (number >= 1)
        {
            for (int i = 1; i <= number; i++){Console.WriteLine(i);}
        }
        else
        {
            for (int i = 1; i >= number; i--){Console.WriteLine(i);}
        }
    }

  }
}
