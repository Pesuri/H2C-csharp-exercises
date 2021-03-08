using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
        string input = "1";
        int currentYear = 2020;
        List<string> names = new List<string>();
        List<string> years = new List<string>();
        while(input != "")
        {
            input = Console.ReadLine();
            if(input != "")
            {
                string[] split = input.Split(',');
                names.Add(split[0]);
                years.Add(split[1]);
            }
            
        }
        int oldestAge = currentYear - Convert.ToInt32(years[0]);
        int longestNameInt = names[0].Length;
        string longestName = names[0];
        for(int i = 0; i < years.Count; i++)
        {
            if(currentYear - Convert.ToInt32(years[i]) > oldestAge)
            {
                oldestAge = currentYear - Convert.ToInt32(years[i]);
            }
            if(longestNameInt < names[i].Length)
            {
                longestNameInt = names[i].Length;
                longestName = names[i];
            }
        }
        Console.WriteLine("Longest name: " + longestName);
        Console.WriteLine("Highest age: " + oldestAge);
    }
  }
}



