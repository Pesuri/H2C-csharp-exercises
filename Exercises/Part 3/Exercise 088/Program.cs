using System;
using System.Collections.Generic;

namespace exercise_88
{
  class Program
  {
    public static void Main(string[] args)
    {
        string input = "1";
        while(input != "")
        {
            input = Console.ReadLine();
            if(input != "")
            {
                string[] split = input.Split(' ');
                Console.WriteLine(split[0]);
            }
        }
    }
  }
}



