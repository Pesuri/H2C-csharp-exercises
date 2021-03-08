using System;
using System.Collections.Generic;

namespace exercise_91
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
        int oldestAge = Convert.ToInt32(ages[0]);
        string oldest = names[0];
        for(int i = 0; i < ages.Count; i++)
        {
            if(Convert.ToInt32(ages[i]) > oldestAge)
            {
                oldest = names[i];
                oldestAge = Convert.ToInt32(ages[i]);
            }
        }
        Console.WriteLine("Name of the oldest: " + oldest);
    }
  }
}



