﻿using System;
using System.Collections.Generic;

namespace exercise_69
{
  class Program
  {
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        while (true)
        {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
            break;
        }
        list.Add(input);
        }
        Console.WriteLine("From where?");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Where to?");
        int end = Convert.ToInt32(Console.ReadLine());
        foreach(int i in list)
        {
            if(i > start & i < end){Console.WriteLine(i);}
        }
    }
  }
}
