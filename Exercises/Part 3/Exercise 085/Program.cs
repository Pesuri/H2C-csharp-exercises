using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
        string[,] login = new string[2,2] {{"alex","sunshine"},{"emma","haskell"}};
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine();
        int loggedin = 0;
        for(int i = 0; i < 2; i++)
        {
            if(login[i,0] == username && login[i,1] == password)
            {
                Console.WriteLine("You have succesfully logged in!");
                loggedin = 1;
            }
        }
        if(loggedin == 0){Console.WriteLine("Incorrect username or password!");}
    }
  }
}

