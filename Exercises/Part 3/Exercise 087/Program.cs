using System;
using System.Collections.Generic;

namespace exercise_87
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
                for(int i = 0; i < split.Length; i++)
                {
                    if(split[i].Contains("av")){Console.WriteLine(split[i]);}
                }

            }
        }
    }

  }

}

