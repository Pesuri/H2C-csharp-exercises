using System;

namespace exercise_120
{
    class Cube
    {
        public int edgeLength;
        public int volume;

        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength; 
        }

        public int Volume()
        {
            return edgeLength * edgeLength * edgeLength;
        }

        public override string ToString()
        {
            return "The length of the edge is " + this.edgeLength + " and the volume " + Volume();
        }
    }
}
