﻿using System;

namespace exercise_99
{
  class Program
  {
    public static void Main(string[] args)
    {

      DecreasingCounter counter = new DecreasingCounter(100);
      counter.PrintValue();
            
      counter.Decrement();
      counter.PrintValue();
      counter.Decrement();
      counter.Decrement();
      counter.Decrement();
      counter.Decrement();
      counter.Decrement();
      counter.PrintValue();
      counter.Reset();
      counter.PrintValue();
    }
  }
}



