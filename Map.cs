using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace neko {
    internal class Map {
        public int treasurePosX = 1;
        public int treasurePosY = 1;

        public int[] treasureData;
        public int[] playerData;
        public int[] enemyData;
        char[,] aryMap;

        public void initMap()
        {
            //initialize map
            aryMap = new char[10, 10] {
                { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
                { '|', '$', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', 'Ȫ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|'},
                { '|', ' ', ' ', '|', ' ', ' ', ' ', 'H', ' ', '|'},
                { '|', '_', '_', '|', '_', '_', '_', '_', '_', '_'}

            };
        }

        public bool checkLoss() {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (aryMap[i, j] == 'H')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool checkWall(int x, int y, int user) {
           if (aryMap[y,x] == ' ' || (aryMap[y,x] == '$' && user == 0)) {
                return true;
            }
           return false;
        }

        public void moveEnemy()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (aryMap[i, j] == 'Ȫ')
                    {
                        aryMap[i, j] = ' ';
                    }
                }
            }
            aryMap[enemyData[1], enemyData[0]] = 'Ȫ';
        }

        public void movePlayer() {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (aryMap[i,j] == 'H')
                    {
                        aryMap[i, j] = ' ';
                    }
                }
            }
            aryMap[playerData[1], playerData[0]] = 'H';
        }

        public void init(int playerPosX, int playerPosY, int enemyPosX, int enemyPosY) { 
            treasureData = new int[2] { treasurePosX, treasurePosY };
            playerData = new int[2] { playerPosX, playerPosY };
            enemyData = new int[2] { enemyPosX, enemyPosY };
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
