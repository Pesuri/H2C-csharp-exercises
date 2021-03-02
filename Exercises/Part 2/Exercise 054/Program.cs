using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
        DivisibleByThreeInRange(9, -3);

    }

    public static void DivisibleByThreeInRange(int beginning, int end)
    {
        if (beginning < end)
        {
            for (int i = beginning; i <= end; i++)
            {
                if (i % 3 == 0){Console.WriteLine(i);}
            }
        }
        else
        {
            for (int i = end; i <= beginning; i++)
            {
                if (i % 3 == 0){Console.WriteLine(i);}
            }
        }

    }

  }
}
