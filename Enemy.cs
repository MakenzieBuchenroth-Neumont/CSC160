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

        Random random = new Random();

        public void initEnemy() {
            enemyPosX = 1;
            enemyPosY = 3;
        }

        public void enemyMove(Map map)
        {
            switch (random.Next(4))
            {
                case 0:
                    if (map.checkWall(enemyPosX, enemyPosY - 1, 1)) {
                        enemyPosY -= 1;
                    }
                    break;
                case 1:
                    if (map.checkWall(enemyPosX, enemyPosY + 1, 1)) {
                        enemyPosY += 1;
                    }
                    break;
                case 2:
                    if (map.checkWall(enemyPosX - 1, enemyPosY, 1)) {
                        enemyPosX -= 1;
                    }
                    break;
                case 3:
                    if (map.checkWall(enemyPosX + 1, enemyPosY, 1))
                    {
                        enemyPosX += 1;
                    }
                    break;
            }
        }
    }
}
