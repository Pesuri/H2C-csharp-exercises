using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
        // You can test your code here.
        Counter counter = new Counter();
        
        Console.WriteLine(counter.value);
        counter.Increase();
        Console.WriteLine(counter.value);
        counter.Decrease();
        Console.WriteLine(counter.value);
        counter.Increase(100);
        Console.WriteLine(counter.value);
        counter.Decrease(20);
        Console.WriteLine(counter.value);
        Console.WriteLine();
        Counter counter2 = new Counter(666);
        Console.WriteLine(counter2.value);
        counter2.Increase();
        Console.WriteLine(counter2.value);
        counter2.Decrease();
        Console.WriteLine(counter2.value);
        counter2.Increase(100);
        Console.WriteLine(counter2.value);
        counter2.Decrease(20);
        Console.WriteLine(counter2.value);


    }
  }
}
