using System;

namespace exercise_123
{
    class Counter
    {
        public int value { get; set; }

        public Counter()
        {
            this.value = 0;
        }

        public Counter(int startValue)
        {
            this.value = startValue;
        }

        public void Increase()
        {
            this.value++;
        }

        public void Decrease()
        {
            this.value--;
        }

        public void Increase(int increaseBy)
        {
            this.value += increaseBy;
        }

        public void Decrease(int decreaseBy)
        {
            this.value -= decreaseBy;
        }

    }
}
