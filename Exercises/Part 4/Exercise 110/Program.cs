using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
        List<Item> items = new List<Item>();
        while(true)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            if(name == "") {break;}
            items.Add(new Item(name));
        }
        items.ForEach(Console.WriteLine);
    }
  }
}




