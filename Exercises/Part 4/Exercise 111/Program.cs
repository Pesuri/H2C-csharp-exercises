using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
        List<PersonalInformation> list = new List<PersonalInformation>();

        while(true)
        {
            Console.WriteLine("First name: ");
            string firstname = Console.ReadLine();
            
            if(firstname == "") {break;}

            Console.WriteLine("Last name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Identification number: ");
            string identification = Console.ReadLine();

            list.Add(new PersonalInformation(firstname, lastname, identification));
        }

        Console.WriteLine();

        foreach(PersonalInformation person in list)
        {
            Console.WriteLine(person.firstName + " " + person.lastName);
        }
    }
  }
}




