using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
        ChristmasTree(10);
    }

    public static void PrintStars(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    public static void PrintSpaces(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.Write(" ");
        }
    }

    public static void PrintRightTriangle(int size)
    {
        for (int i = 0; i < size; i++)
        {
            PrintSpaces(size-(i+1));
            PrintStars(1+i);
        }
    }

    public static void ChristmasTree(int height)
    {
        for (int i = 0; i < height; i++)
        {
            PrintSpaces(height - (i + 1));
            PrintStars(1 + 2 * i);
        }
        for (int i = 0; i < 2; i++)
        {
            PrintSpaces(height - 2);
            PrintStars(3);
        }
    }
  }
}
