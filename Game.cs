using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neko
{
    internal class Game
    {
        public bool end = false;
        public bool win = false;
        Player player = new Player();
        Map map = new Map();
        Enemy enemy = new Enemy();

        public void checkWin()
        {
            // fix next line
            if (map.playerData[0] == map.treasureData[0] && map.playerData[1] == map.treasureData[1])
            {
                end = true;
                win = true;
            }
        }

        public void checkLose()
        {
            // fix next line
            if (map.playerData[0] == map.enemyData[0] && map.playerData[1] == map.enemyData[1])
            {
                end = true;
                win = false;
            }
        }

        public void playGame()
        {
            while (!end)
            {
                map.printMap();
                Console.WriteLine("Please presss the arrow key of the direction you want to go!");
                player.Movement();
                enemy.enemyMove();
                checkWin();
            }
            if (end)
            {
                if (win)
                {
                    Console.WriteLine("You successfully got the treasure! Congraturations!");
                }
                else
                {
                    Console.WriteLine("You were caught! Sadge!");
                }
            }
        }
    }
}
