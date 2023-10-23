using neko;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace neko
{
    internal class Program
    {

        static void Main(string[] args) {
        Game game = new Game();
            bool playingValidInput = false;

            while (!playingValidInput) {
                Console.WriteLine("Would you like to play 'Grab the Teasure'?");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Exit");
                string playingInput = Console.ReadLine();
                int playingInputInt = Int32.Parse(playingInput);
                if (playingInputInt == 1) {
                    game.end = false;
                    Console.WriteLine("Please enter your name:");
                    string playerName = Console.ReadLine();
                    Console.WriteLine("Hello, " + playerName);
                    Console.WriteLine("Player = H, Enemy = Ȫ, Treasure = $");
                    game.playGame();
                }
                else if(playingInputInt == 2) {
                    playingValidInput = true;
                }
            }

        }
    }
}
