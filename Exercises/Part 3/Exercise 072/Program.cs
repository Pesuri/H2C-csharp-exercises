using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {   
        int number = 0;
        List<int> numbers = new List<int>();
        while(number != 9999)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if(number != 9999)
            {
                numbers.Add(number);
            }
        }
        int smallest = numbers[0];
        for(int i = 0; i < numbers.Count; i++)
        {
            if(numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }
        List<int> searchResults = new List<int>();
        for(int i = 0; i < numbers.Count; i++)
        {
            if(numbers[i] == smallest){searchResults.Add(i);}
        }
        Console.WriteLine("Smallest number: " + smallest);
        foreach(int i in searchResults)
        {
            Console.WriteLine("Found at index " + i);
        }
    }
  }
}
