using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Do you want to continue?");
            string vastaus = Console.ReadLine();
            if (vastaus == "no") {break;}
        }          
    }
  }
}
