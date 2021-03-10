using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            while(true)
            {
                string text = Console.ReadLine();

                if(text == "end") { break; }

                count++;
            }
            Console.WriteLine(count);
        }
    }
}
