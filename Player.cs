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
        public int totalRoll;
        /// <summary>
        /// Moves the player
        /// </summary>
        public void Move(int movement)
        {
            position += movement;
            if(position>100)
            {
                position -= movement;
                Console.WriteLine("You crossed 100 so moving back to last position");
            }
        }
        /// <summary>
        /// Rolls the dice
        /// </summary>
        public void RollDice()
        {
            roll = random.Next(1, 7);
            totalRoll++;
            Display();
            Console.WriteLine("Player rolled: " + roll);
            Move(roll);
            Option();
        }
        /// <summary>
        /// Displays player position
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Player position: " + position);
        }
        /// <summary>
        /// Options for snake and ladder
        /// </summary>
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
