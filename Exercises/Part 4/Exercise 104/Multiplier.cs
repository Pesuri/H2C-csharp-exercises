using System;

namespace exercise_104
{
    class Multiplier
    {
        private int multiplier;

        public Multiplier(int number)
        {
            this.multiplier = number;
        }

        public int Multiply(int number)
        {
            multiplier = number * multiplier;
            return multiplier;
        }
    }
}



