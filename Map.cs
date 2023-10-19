using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace neko {
    internal class Map {
        Player player = new Player();
        Enemy enemy = new Enemy();
        public int treasurePosX = 1;
        public int treasurePosY = 1;

        public int[] treasureData;
        public int[] playerData;
        public int[] enemyData;
            
            //initialize map
            char[,] aryMap = new char[10, 10] {
                { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
                { '|', '$', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', 'Ȫ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', '|', ' ', ' ', ' ', 'H', ' ', '|'},
                { '|', '_', '_', '|', '_', '_', ' ', ' ', ' ', '_'}

            };
        public void init() { 
            treasureData = new int[2] { treasurePosX, treasurePosY };
            playerData = new int[2] { player.playerPosX, player.playerPosY };
            enemyData = new int[2] { enemy.enemyPosX, enemy.enemyPosY };
        }



        public void printMap()
        {
            for (int row = 0; row < aryMap.GetLength(0); row++)
            {
                Console.WriteLine(" ");
                for (int col = 0; col < aryMap.GetLength(1); col++)
                {
                    Console.Write(aryMap[row, col]);
                }
            }
        }
    }
}
