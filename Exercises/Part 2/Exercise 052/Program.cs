using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
        PrintFromNumberToOne(10);
    }

    public static void PrintFromNumberToOne(int number)
    {
        if (number <= 1)
        {
            for (int i = number; i <= 1; i++){Console.WriteLine(i);}
        }
        else
        {
            for (int i = number; i >=1; i--){Console.WriteLine(i);} 
        }
    }

  }
}
