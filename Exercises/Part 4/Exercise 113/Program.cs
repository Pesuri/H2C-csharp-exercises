using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
        List<Book> list = new List<Book>();

        while(true)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            if(name == "") {break;}

            Console.Write("Pages: ");
            int pages = Convert.ToInt32(Console.ReadLine());
            Console.Write("Publication year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            list.Add(new Book(name, pages, year));
        }
        Console.WriteLine();
        
        Console.Write("What informaton will be printed? ");
        string answer = Console.ReadLine();

        if(answer == "everything")
        {
            list.ForEach(Console.WriteLine);
        }
        else if(answer == "title")
        {
            foreach(Book info in list)
            {
                Console.WriteLine(info.name);
            }
        }
    }
  }
}




