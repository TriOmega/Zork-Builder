using System;

namespace Zork
{
    class Program
    {
        private string Location
        {
            get
            {
                return Rooms[LocationColumn];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while (true)
            {
                Console.Write($"{Rooms[LocationColumn]}\n> ");
                command = ToCommand(Console.ReadLine().Trim());
                if (command == Commands.QUIT)
                {
                    break;
                }

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing.";
                        break;

                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door.\n\nA rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = Move(command) ? $"You moved {command}." : "The way is shut!";
                        break;

                    default:
                        outputString = "Unrecognized command";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static bool Move(Commands command)
        {
            bool didMove;
            switch (command)
            {
                case Commands.NORTH:
                    didMove = false;
                    break;
                case Commands.SOUTH:
                    didMove = false;
                    break;
                case Commands.EAST when LocationColumn < Rooms.Length - 1:
                    LocationColumn++;
                    didMove = true;
                    break;
                case Commands.WEST when LocationColumn > 0:
                    LocationColumn--;
                    didMove = true;
                    break;
                default:
                    didMove = false;
                    break;
            }
            return didMove;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static string[] Rooms = { "Forest", "West of House", "Behind House", "Clearing", "Canyon View" };
        private static int LocationColumn = 1;
    }
}
