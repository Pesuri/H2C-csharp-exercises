using System;

namespace exercise_98
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Create Product.cs and follow the instructions.
      // You can test your class with this.
      
        Product Banana = new Product("Banana", 2.1, 300);
        Product bagOfHolding = new Product("Bag of Holding", 2000, 1);
        Banana.PrintProduct(); 
        bagOfHolding.PrintProduct(); 
             
    }
  }
}



