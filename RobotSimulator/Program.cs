using System;
using System.IO;

namespace RobotSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            Console.WriteLine("Enter 'file' to read from commands.txt, or any key to input commands manually:");

            string input = Console.ReadLine();
            switch (input?.ToLower())
            {
                case "file":
                    ReadCommandsFromFile(robot, "commands.txt");
                    break;
                default:
                    ReadCommandsFromConsole(robot);
                    break;
            }

            Console.ReadLine();


        }
        static void ReadCommandsFromConsole(Robot robot)
        {
            Console.WriteLine("Enter commands (type 'EXIT' to quit):");
            string input;
            while ((input = Console.ReadLine()) != "EXIT")
            {
                ExecuteCommands(robot, new string[] { input });
            }

            Environment.Exit(0);

        }

        static void ReadCommandsFromFile(Robot robot, string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
            }
            else
            {
                string[] commands = File.ReadAllLines(filePath);
                ExecuteCommands(robot, commands);
            }
        }

        static void ExecuteCommands(Robot robot, string[] commands)
        {
            foreach (var command in commands)
            {
                var parts = command.Split(' ');
                switch (parts[0])
                {
                    case "PLACE":
                        if (parts.Length > 1)
                        {
                            var args = parts[1].Split(',');
                            if (args.Length == 3 && int.TryParse(args[0], out int x) && int.TryParse(args[1], out int y))
                            {
                                robot.Place(x, y, args[2]);
                            }
                        }
                        break;
                    case "MOVE":
                        robot.Move();
                        break;
                    case "LEFT":
                        robot.Left();
                        break;
                    case "RIGHT":
                        robot.Right();
                        break;
                    case "REPORT":
                        robot.Report();
                        break;
                }
            }
        }
    }
}
