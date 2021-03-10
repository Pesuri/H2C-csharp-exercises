using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
            while(true)
            {
                string text = Console.ReadLine();

                if(text == "end") { break; }

                int number = Convert.ToInt32(text);

                int cube = number * number * number;
                
                Console.WriteLine(cube);
            }
    }
  }
}
