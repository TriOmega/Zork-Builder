using System;
using System.ComponentModel.Design;

namespace Zork
{
    class Program
    {
        private string Location
        {
            get
            {
                return Rooms[LocationRow,LocationColumn];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while (true)
            {
                Console.Write($"{Rooms[LocationRow,LocationColumn]}\n> ");
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
                case Commands.NORTH when LocationColumn < Rooms.Length - 1:
                    didMove = true;
                    break;
                case Commands.SOUTH when LocationRow > 0:
                    didMove = true;
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

        private static string[,] Rooms =
        { 
            {"Rocky Trail", "South of House", "Canyon View"},
            {"Forest","West of House","Behind House"},
            {"Dense Woods", "North of House", "Clearing"}
        };
        private static int LocationColumn = 1;
        private static int LocationRow = 1;
    }
}
