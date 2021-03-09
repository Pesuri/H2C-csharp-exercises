using System;
using System.Collections.Generic;

namespace exercise_113
{
    public class Book
    {
        public string name;
        public int year;
        public int pages;

        public Book(string name, int pages, int year)
        {
            this.name = name;
            this.year = year;
            this.pages = pages;
        }

        public override string ToString()
        {
            return name + ", " + pages + " pages, " + year; 
        }
    }
}




