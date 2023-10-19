using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neko {
    internal class Enemy
    {
        public int enemyPosX = 1;
        public int enemyPosY = 3;

        public void enemyMove()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    if (enemyPosY == 9)
                    {
                        Console.WriteLine("Cannot move that way!");
                    }
                    enemyPosY -= 1;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    if (enemyPosY == 1)
                    {
                        Console.WriteLine("Cannot move that way!");
                    }
                    enemyPosY += 1;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    if (enemyPosX == 1)
                    {
                        Console.WriteLine("Cannot move that way!");
                    }
                    enemyPosX += 1;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    if (enemyPosX == 9)
                    {
                        Console.WriteLine("Cannot move that way!");
                    }
                    enemyPosX -= 1;
                    break;
            }
        }
    }
}
