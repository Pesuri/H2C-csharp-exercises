using System;

namespace exercise_121
{
    class Fitbyte
    {
        public int age;
        public int restingHeartRate;
        public double maxHeartRate;

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
            this.maxHeartRate = 206.3 - (0.711 * age);
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            return (maxHeartRate - restingHeartRate) *(percentageOfMaximum) + restingHeartRate;
        }
    }
}
