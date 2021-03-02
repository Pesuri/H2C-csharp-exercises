using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Where to?");
        int numeroLoppu = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Where from?");
        int numeroAlku = Convert.ToInt32(Console.ReadLine());
        
        if (numeroAlku < numeroLoppu)
        {
            for (int i = numeroAlku; i <= numeroLoppu; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
  }
}
