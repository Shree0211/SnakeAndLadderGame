using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class Player
    {
       public int position = 0;
        public static Random random = new Random();
        public void move(int roll)
        {
            position += roll;
        }
        public void RollDice()
        {
            int roll = random.Next(1, 7);
            move(roll);
        }

        public void Display()
        {
            Console.WriteLine("Player position: " + position);
        }
    }
}
