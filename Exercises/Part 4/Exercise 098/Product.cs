using System;

namespace exercise_98
{
  class Product
  {
        public double priceX;
        public int quantityX;
        public string nameX;

        public Product(string name, double price, int quantity)
        {
            this.priceX = price;
            this.quantityX = quantity;
            this.nameX = name;
        }

        public void PrintProduct()
        {
            Console.WriteLine(nameX + ": price " + priceX + ": " + quantityX + " pcs");
        }
  }
}



