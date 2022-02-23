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
        public int roll;
        public void Move(int movement)
        {
            position += movement;
        }
        public void RollDice()
        {
            roll = random.Next(1, 7);
            Console.WriteLine("Player rolled: " + roll);
            Move(roll);
            Option();
        }
        public void Display()
        {
            Console.WriteLine("Player position: " + position);
        }

        public void Option()
        {
            int option = random.Next(0, 3);
            switch (option)
            {
                    case 0:
                    Console.WriteLine("No Play");
                    break;

                case 1:
                    Console.WriteLine("You are on Snake");
                    Move(-roll);
                    break;

                case 2:
                    Console.WriteLine("You found a ladder");
                    Move(roll);
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
