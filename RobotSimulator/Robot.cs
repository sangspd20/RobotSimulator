using System;

namespace RobotSimulator
{
    public class Robot
    {
        private int x, y;
        private string direction;
        private bool isPlaced = false;

        public void Place(int newX, int newY, string newDirection)
        {
            if (IsValidPosition(newX, newY) && Array.Exists(Constants.DIRECTIONS, d => d == newDirection))
            {
                x = newX;
                y = newY;
                direction = newDirection;
                isPlaced = true;
            }
        }

        public void Move()
        {
            if (!isPlaced) return;

            int newX = x, newY = y;
            switch (direction)
            {
                case "NORTH": newY++; break;
                case "SOUTH": newY--; break;
                case "EAST": newX++; break;
                case "WEST": newX--; break;
            }

            if (IsValidPosition(newX, newY))
            {
                x = newX;
                y = newY;
            }
        }

        public void Left()
        {
            if (!isPlaced) return;
            int index = Array.IndexOf(Constants.DIRECTIONS, direction);
            direction = Constants.DIRECTIONS[(index + 3) % 4];
        }

        public void Right()
        {
            if (!isPlaced) return;
            int index = Array.IndexOf(Constants.DIRECTIONS, direction);
            direction = Constants.DIRECTIONS[(index + 1) % 4];
        }

        public void Report()
        {
            if (isPlaced)
                Console.WriteLine($"{x},{y},{direction}");
            else
                Console.WriteLine("Robot not placed on the table.");
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < Constants.TABLE_SIZE && y >= 0 && y < Constants.TABLE_SIZE;
        }
    }

}
