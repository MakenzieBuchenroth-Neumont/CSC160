using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neko
{
    internal class Player
    {
        public int playerPosX = 7;
        public int playerPosY = 8;

        public void Movement()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    if (playerPosY == 1)
                    {
                        Console.WriteLine("Cannot move that way!");
                    }
                    playerPosY -= 1;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    if (playerPosY == 9)
                    {
                        Console.WriteLine("Cannot move that way!");
                    }
                    playerPosY += 1;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    if (playerPosX == 1)
                    {
                        Console.WriteLine("Cannot move that way!");
                    }
                    playerPosX -= 1;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    if (playerPosX == 9)
                    {
                        Console.WriteLine("Cannot move that way!");
                    }
                    playerPosX += 1;
                    break;
            }
        }
    }
}
