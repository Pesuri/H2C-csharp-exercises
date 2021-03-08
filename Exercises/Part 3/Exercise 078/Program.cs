﻿using System;
using System.Collections.Generic;

namespace exercise_78
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[5];
      array[0] = 1;
      array[1] = 3;
      array[2] = 5;
      array[3] = 7;
      array[4] = 9;

      int index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }
      Console.WriteLine("");

      // Implement here
      // asking for the two indices
      // and then swapping them
      Console.WriteLine("Give two indices to swap:");
      int indice1 = Convert.ToInt32(Console.ReadLine());
      int indice2 = Convert.ToInt32(Console.ReadLine());
      int swap1 = array[indice1];
      int swap2 = array[indice2];
      array[indice1] = swap2;
      array[indice2] = swap1;

      // DO NOT CHANGE THE FOLLOWING CODE!
      Console.WriteLine("");
      index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }
    }

  }
}


