using System;
using System.Collections.Generic;

namespace exercise_135
{
    class UserInterface
    {
        private JokeManager manager;

        public UserInterface(JokeManager manager)
        {
            this.manager = manager;
        }
    
        public void Start()
        {
            while(true)
            {
                string command = AskForCommand();

                if (command == "X") { break; }

                HandleCommand(command);
            }
        }

        public string AskForCommand()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine(" 1 - add a joke");
            Console.WriteLine(" 2 - draw a joke");
            Console.WriteLine(" 3 - list jokes");
            Console.WriteLine(" X - stop");

            string command = Console.ReadLine();

            return command;
        }

        public void HandleCommand(string command)
        {

            if (command == "1")
            {
                Console.WriteLine("Write the joke to be added:");
                string joke = Console.ReadLine();
                this.manager.AddJoke(joke);
            }
            else if (command == "2")
            {
                Console.WriteLine(this.manager.DrawJoke());
            }
            else if (command == "3")
            {
                this.manager.PrintJokes();
            }
        }

    }
}