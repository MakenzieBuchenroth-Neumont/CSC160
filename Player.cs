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

        public void initPlayer() {
            playerPosX = 7;
            playerPosY = 8;
        }

        public void Movement(Map map)
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    if (map.checkWall(playerPosX, playerPosY - 1, 0)) {
                        playerPosY -= 1;
                    }
                    else { 
                        Console.WriteLine("Cannot move that way!");
                    }
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    if (map.checkWall(playerPosX, playerPosY + 1, 0)) {
                        playerPosY += 1;
                    }
                    else {
                        Console.WriteLine("Cannot move that way!");
                    }
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    if (map.checkWall(playerPosX -1, playerPosY, 0)) {
                        playerPosX -= 1;
                    }
                    else {
                        Console.WriteLine("Cannot move that way!");
                    }
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    if (map.checkWall(playerPosX + 1, playerPosY, 0)) {
                        playerPosX += 1;
                    }
                    else {
                        Console.WriteLine("Cannot move that way!");
                    }
                    break;
            }
        }
    }
}
