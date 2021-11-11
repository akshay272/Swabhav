using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGameApp
{
    class Program
    {
        public static int turnCount = 1;
        private static int totalScore = 0;
        private static int MAX_SCORE = 20;
        private static int currentScore = 0;
        private static int diceValue = 0;
        private static int holdScore = 0;

        private static void rollDice()
        {
            Random random = new Random();
            diceValue = random.Next(1, 7);
            Console.WriteLine(diceValue);
            if (diceValue == 1)
            {
                ++turnCount ;
                
                totalScore = 0;
                Console.WriteLine("Turn : " + turnCount);
                Console.WriteLine("Turn Over No Score !!");
                currentScore = 0;
                totalScore = 0; 

                return;
            }
            else
            {
                currentScore += diceValue;
                totalScore += currentScore;
                return;

                
            }
            
        }

        public static void holdDice()
        {
            
            totalScore = currentScore;
            
            turnCount++;
            if (totalScore >= MAX_SCORE)
            {
                Console.WriteLine("You Finished in " + turnCount + "Turns");
                return;
            }
            Console.WriteLine(" Score for this Turn : " + currentScore);
            Console.WriteLine("Total Score : " + totalScore);
            currentScore = 0;
            return;

        }

        private static void StartGame()
        {
            Console.WriteLine("TURN : " + turnCount);
            while (true)
            {
                Console.WriteLine(" Roll or Hold ? (r/h) ");
                char roll = 'r';
                char hold = 'h';
                char userDecision = Convert.ToChar(Console.ReadLine());
                if(userDecision == roll)
                {
                    rollDice();
                }
                else if (userDecision == hold)
                {
                    holdDice();
                    
                }
                
                
            }
        }

        public static void Main(string[] args)
         {
            Console.WriteLine("**** Welcome to PIG Game ****");
            while (true)
            {
                Console.WriteLine("Turn : " + turnCount);
                StartGame();
                

            }

        }
    }
}
