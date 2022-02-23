using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class Game
    {
        Player P1 = new Player();
        Player P2 = new Player();
        Random random = new Random();
        /// <summary>
        /// Starts the game
        /// </summary>
        public void start()
        {
            while(P1.position<100 && P2.position<100)
            {
                Console.WriteLine("Player1 : ");
                P1.RollDice();
                P1.Display();
                if (P1.position == 100)
                    break;
                P2.RollDice();
                P2.Display();
            }
            Console.WriteLine("Player1 total rolled:" +P1.totalRoll);
            Console.WriteLine("Player2 total rolled:" +P2.totalRoll);

            if (P2.position == 100)
            {
                Console.WriteLine("Player 2 has won!!");
            }
            else
                Console.WriteLine("Player 1 has won!!");
        }
      
    }
    
}
