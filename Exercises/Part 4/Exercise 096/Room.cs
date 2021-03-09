using System;

namespace exercise_96
{
    class Room
    {
        private string code;
        private int sEats;

        public Room(string classCode, int numberOfSEats)
        {
            this.code = classCode;
            this.sEats = numberOfSEats;
        }
    }
}
