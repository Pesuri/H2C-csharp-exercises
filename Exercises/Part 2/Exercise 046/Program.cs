﻿using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {
        int numero = Convert.ToInt32(Console.ReadLine());
        for (int i = numero; i <= 100; i++)
        {
            Console.WriteLine(i);
        }
    }
  }
}
