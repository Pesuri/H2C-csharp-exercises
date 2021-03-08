using System;
using System.Collections.Generic;

namespace exercise_71
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
        Console.WriteLine("Search for?");
        int search = Convert.ToInt32(Console.ReadLine());
        List<int> searchResults = new List<int>();
        if(list.Contains(search))
        {
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] == search){searchResults.Add(i);}
            }       
            foreach(int i in searchResults)
            {
                Console.WriteLine(search + " is at index " + i);
            }
        }

    }
  }
}
