using System;
using System.Collections.Generic;

namespace exercise_131
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<Item> items = new List<Item>();

           

      // Ask for input as shown in the exercise.
      while(true)
      {
        Console.WriteLine("Identifier? (empty will stop)");
        string identifier = Console.ReadLine();
        if(identifier == "") { break; }
        Console.WriteLine("Name? (empty will stop)");
        string name = Console.ReadLine();
        if(name == "") { break; }

        Item itemX = new Item(identifier, name);
        bool found = false;
        foreach(Item item in items)
        {
            if(itemX.Equals(item)) { found = true; break; }
        }
        if(!found) {items.Add(itemX);}
      }

      // The end printing is ready, don't touch this
      Console.WriteLine("==Items==");
      foreach (Item item in items)
      {
        Console.WriteLine(item);
      }

    }

  }
}
