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
        Random random = new Random();
        public void start()
        {
            while(P1.position<100)
            {
                P1.RollDice();
                P1.Display();
            }
        }
      
    }
    
}
