using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
        string input = "1";
        List<string> names = new List<string>();
        List<string> ages = new List<string>();
        while(input != "")
        {
            input = Console.ReadLine();
            if(input != "")
            {
                string[] split = input.Split(',');
                names.Add(split[0]);
                ages.Add(split[1]);
            }
            
        }
        int oldest = Convert.ToInt32(ages[0]);
        foreach(string age in ages)
        {
            if(Convert.ToInt32(age) > oldest){oldest = Convert.ToInt32(age);}
        }
        Console.WriteLine("Age of the oldest: " + oldest);
    }
  }
}



